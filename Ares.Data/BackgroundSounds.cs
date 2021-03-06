﻿/*
 Copyright (c) 2015 [Joerg Ruedenauer]
 
 This file is part of Ares.

 Ares is free software; you can redistribute it and/or modify
 it under the terms of the GNU General Public License as published by
 the Free Software Foundation; either version 2 of the License, or
 (at your option) any later version.

 Ares is distributed in the hope that it will be useful,
 but WITHOUT ANY WARRANTY; without even the implied warranty of
 MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 GNU General Public License for more details.

 You should have received a copy of the GNU General Public License
 along with Ares; if not, write to the Free Software
 Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
 */
using System;
using System.Collections.Generic;

namespace Ares.Data
{
    [Serializable]
    class BackgroundSoundChoice : ElementBase, IBackgroundSoundChoice
    {

        #region IElementContainer<IChoiceElement> Members

        public IElement AddGeneralElement(IElement element)
        {
            return AddElement(element);
        }

        public IList<IElement> AddGeneralImportedElement(IXmlWritable element)
        {
            List<IElement> result = new List<IElement>();
            if (element is IChoiceElement)
            {
                IChoiceElement choice = element as IChoiceElement;
                if (choice.InnerElement is IFileElement)
                {
                    result.AddRange(m_Container.AddGeneralImportedElement(element));
                    return result;
                }
            }
            foreach (IFileElement fileElement in element.GetFileElements())
            {
                result.Add(m_Container.AddElement(fileElement));
            }
            return result;
        }

        public void InsertGeneralElement(int index, IElement element)
        {
            m_Container.InsertGeneralElement(index, element);
        }

        public IChoiceElement AddElement(IElement element)
        {
            return m_Container.AddElement(element);
        }

        public void RemoveElement(int ID)
        {
            m_Container.RemoveElement(ID);
        }

        public IList<IContainerElement> GetGeneralElements()
        {
            return m_Container.GetGeneralElements();
        }

        public IList<IChoiceElement> GetElements()
        {
            return m_Container.GetElements();
        }

        public IList<IFileElement> GetFileElements()
        {
            return m_Container.GetFileElements();
        }

        public IChoiceElement GetElement(int ID)
        {
            return m_Container.GetElement(ID);
        }

        public bool ShowArtistColumn {  get { return false; } set { } }

        public bool ShowAlbumColumn {  get { return false; } set { } }

        #endregion

        #region IDelayableElement Members

        public TimeSpan FixedStartDelay
        {
            get
            {
                return ParallelElement.FixedStartDelay;
            }
            set
            {
                ParallelElement.FixedStartDelay = value;
            }
        }

        public TimeSpan MaximumRandomStartDelay
        {
            get
            {
                return ParallelElement.MaximumRandomStartDelay;
            }
            set
            {
                ParallelElement.MaximumRandomStartDelay = value;
            }
        }

        #endregion

        #region IRepeatableElement Members

        public int RepeatCount
        {
            get
            {
                return ParallelElement.RepeatCount;
            }
            set
            {
                ParallelElement.RepeatCount = value;
            }
        }

        public TimeSpan FixedIntermediateDelay
        {
            get
            {
                return ParallelElement.FixedIntermediateDelay;
            }
            set
            {
                ParallelElement.FixedIntermediateDelay = value;
            }
        }

        public TimeSpan MaximumRandomIntermediateDelay
        {
            get
            {
                return ParallelElement.MaximumRandomIntermediateDelay;
            }
            set
            {
                ParallelElement.MaximumRandomIntermediateDelay = value;
            }
        }

        #endregion

        public override void Visit(IElementVisitor visitor)
        {
            visitor.VisitChoiceContainer(m_Container);
        }

        public override void WriteToXml(System.Xml.XmlWriter writer)
        {
            writer.WriteStartElement("BackgroundSoundChoice");
            DoWriteToXml(writer);
            m_Container.WriteToXml(writer);
            writer.WriteEndElement();
        }

        public IElement InnerElement { get { return this; } }

        internal BackgroundSoundChoice(Int32 id, String title)
            : base(id)
        {
            Title = title;
            m_Container = DataModule.ElementFactory.CreateChoiceContainer(title + "_Choice");
        }

        internal BackgroundSoundChoice(System.Xml.XmlReader reader)
            : base(reader)
        {
            if (reader.IsEmptyElement)
            {
                XmlHelpers.ThrowException(StringResources.ExpectedContent, reader);
            }
            reader.Read();
            m_Container = DataModule.TheElementFactory.CreateChoiceContainer(reader);
            reader.ReadEndElement();
        }

        internal IParallelElement ParallelElement { get; set; }

        private IElementContainer<IChoiceElement> m_Container;
    }

    class BackgroundSounds : ElementBase, IBackgroundSounds
    {

        #region IElementContainer<IBackgroundSoundChoice> Members

        public IBackgroundSoundChoice AddElement(String title)
        {
            BackgroundSoundChoice choice = new BackgroundSoundChoice(
                DataModule.TheElementFactory.GetNextID(), title);
            IParallelElement parallelElement = m_Container.AddElement(choice);
            parallelElement.RepeatCount = -1;
            choice.ParallelElement = parallelElement;
            m_Elements.Add(choice);
            return choice;
        }

        public IBackgroundSoundChoice AddImportedElement(IXmlWritable writable)
        {
            ImportedChoice choice = writable as ImportedChoice;
            if (choice == null)
                return null;
            BackgroundSoundChoice bgChoice = choice.SoundChoice;
            IParallelElement parallelElement = m_Container.AddElement(bgChoice);
            parallelElement.FixedStartDelay = choice.ChoiceData.FixedStartDelay;
            parallelElement.FixedIntermediateDelay = choice.ChoiceData.FixedIntermediateDelay;
            parallelElement.MaximumRandomStartDelay = choice.ChoiceData.MaximumRandomStartDelay;
            parallelElement.MaximumRandomIntermediateDelay = choice.ChoiceData.MaximumRandomIntermediateDelay;
            parallelElement.RepeatCount = choice.ChoiceData.RepeatCount;
            bgChoice.ParallelElement = parallelElement;
            m_Elements.Add(bgChoice);
            return bgChoice;
        }

        public IList<IElement> AddGeneralImportedElement(IXmlWritable writable)
        {
            List<IElement> result = new List<IElement>();
            IElement element = AddImportedElement(writable);
            if (element != null)
                result.Add(element);
            return result;
        }

        public IBackgroundSoundChoice AddElement(IElement element)
        {
            throw new InvalidOperationException();
        }

        public IElement AddGeneralElement(IElement element)
        {
            throw new InvalidOperationException();
        }

        public void InsertElement(int index, IBackgroundSoundChoice element)
        {
            BackgroundSoundChoice bsc = element as BackgroundSoundChoice;
            m_Container.InsertGeneralElement(index, bsc.ParallelElement);
            m_Elements.Insert(index, bsc);
        }

        public void InsertGeneralElement(int index, IElement element)
        {
            InsertElement(index, element as IBackgroundSoundChoice);
        }

        public void RemoveElement(Int32 id)
        {
            IBackgroundSoundChoice element = m_Elements.Find(e => e.Id == id);
            if (element != null)
            {
                m_Elements.Remove(element);
                m_Container.RemoveElement((element as BackgroundSoundChoice).ParallelElement.Id);
            }
        }

        public IList<IBackgroundSoundChoice> GetElements()
        {
            return new List<IBackgroundSoundChoice>(m_Elements);
        }

        public IList<IContainerElement> GetGeneralElements()
        {
            List<IContainerElement> elements = new List<IContainerElement>(m_Elements.Count);
            m_Elements.ForEach(e => elements.Add(e));
            return elements;
        }

        public IList<IFileElement> GetFileElements()
        {
            FileElementSearcher searcher = new FileElementSearcher();
            this.Visit(searcher);
            return searcher.GetFoundElements();            
        }

        public IBackgroundSoundChoice GetElement(int ID)
        {
            return m_Elements.Find(e => e.Id == ID);
        }

        public bool ShowArtistColumn { get { return false; } set { } }

        public bool ShowAlbumColumn { get { return false; } set { } }

        #endregion

        public override void Visit(IElementVisitor visitor)
        {
            visitor.VisitParallelContainer(m_Container);
        }

        internal BackgroundSounds(Int32 id, String title)
            : base(id)
        {
            Title = title;
            m_Elements = new List<IBackgroundSoundChoice>();
            m_Container = DataModule.ElementFactory.CreateParallelContainer(title + "_Parallel");
        }

        internal static void WriteAdditionalData(System.Xml.XmlWriter writer, IBackgroundSoundChoice choice)
        {
            writer.WriteStartElement("ParallelElementData");
            writer.WriteAttributeString("FixedStartDelay", choice.FixedStartDelay.TotalMilliseconds.ToString(System.Globalization.CultureInfo.InvariantCulture));
            writer.WriteAttributeString("RandomStartDelay", choice.MaximumRandomStartDelay.TotalMilliseconds.ToString(System.Globalization.CultureInfo.InvariantCulture));
            writer.WriteAttributeString("FixedInterDelay", choice.FixedIntermediateDelay.TotalMilliseconds.ToString(System.Globalization.CultureInfo.InvariantCulture));
            writer.WriteAttributeString("RandomInterDelay", choice.MaximumRandomIntermediateDelay.TotalMilliseconds.ToString(System.Globalization.CultureInfo.InvariantCulture));
            writer.WriteAttributeString("RepeatCount", choice.RepeatCount.ToString(System.Globalization.CultureInfo.InvariantCulture));
            writer.WriteEndElement();
        }

        public override void WriteToXml(System.Xml.XmlWriter writer)
        {
            writer.WriteStartElement("BackgroundSounds");
            DoWriteToXml(writer);
            writer.WriteAttributeString("ContainerId", m_Container.Id.ToString(System.Globalization.CultureInfo.InvariantCulture));
            writer.WriteStartElement("SubElements");
            foreach (IBackgroundSoundChoice choice in m_Elements)
            {
                choice.WriteToXml(writer);
                WriteAdditionalData(writer, choice);
            }
            writer.WriteEndElement();
            writer.WriteEndElement();
        }

        internal class AdditionalChoiceData
        {
           public TimeSpan FixedStartDelay;
           public TimeSpan MaximumRandomStartDelay;
           public TimeSpan FixedIntermediateDelay;
           public TimeSpan MaximumRandomIntermediateDelay;
           public Int32 RepeatCount;
        }

        internal class ImportedChoice : IBackgroundSoundChoice
        {
            public BackgroundSoundChoice SoundChoice;
            public AdditionalChoiceData ChoiceData;

            public ImportedChoice(BackgroundSoundChoice soundChoice, AdditionalChoiceData choiceData)
            {
                SoundChoice = soundChoice;
                ChoiceData = choiceData;
            }

            public string Title
            {
                get
                {
                    return SoundChoice.Title;
                }
                set
                {
                    SoundChoice.Title = value;
                }
            }

            #region Not Implemented Members of IBackgroundSoundChoice

            public void WriteToXml(System.Xml.XmlWriter writer)
            {
                throw new NotImplementedException();
            }

            public IChoiceElement AddElement(IElement element)
            {
                throw new NotImplementedException();
            }

            public IList<IChoiceElement> GetElements()
            {
                throw new NotImplementedException();
            }

            public IChoiceElement GetElement(int id)
            {
                throw new NotImplementedException();
            }

            public IList<IContainerElement> GetGeneralElements()
            {
                throw new NotImplementedException();
            }

            public IElement AddGeneralElement(IElement element)
            {
                throw new NotImplementedException();
            }

            public IList<IElement> AddGeneralImportedElement(IXmlWritable element)
            {
                throw new NotImplementedException();
            }

            public void InsertGeneralElement(int index, IElement element)
            {
                throw new NotImplementedException();
            }

            public void RemoveElement(int id)
            {
                throw new NotImplementedException();
            }

            public IList<IFileElement> GetFileElements()
            {
                throw new NotImplementedException();
            }

            public int Id
            {
                get
                {
                    throw new NotImplementedException();
                }
                set
                {
                    throw new NotImplementedException();
                }
            }

            public bool SetsMusicVolume
            {
                get
                {
                    throw new NotImplementedException();
                }
                set
                {
                    throw new NotImplementedException();
                }
            }

            public int MusicVolume
            {
                get
                {
                    throw new NotImplementedException();
                }
                set
                {
                    throw new NotImplementedException();
                }
            }

            public bool SetsSoundVolume
            {
                get
                {
                    throw new NotImplementedException();
                }
                set
                {
                    throw new NotImplementedException();
                }
            }

            public int SoundVolume
            {
                get
                {
                    throw new NotImplementedException();
                }
                set
                {
                    throw new NotImplementedException();
                }
            }

            public IElement Clone()
            {
                throw new NotImplementedException();
            }

            public void Visit(IElementVisitor visitor)
            {
                throw new NotImplementedException();
            }

            public IElement InnerElement
            {
                get { throw new NotImplementedException(); }
            }

            public TimeSpan FixedStartDelay
            {
                get
                {
                    throw new NotImplementedException();
                }
                set
                {
                    throw new NotImplementedException();
                }
            }

            public TimeSpan MaximumRandomStartDelay
            {
                get
                {
                    throw new NotImplementedException();
                }
                set
                {
                    throw new NotImplementedException();
                }
            }

            public int RepeatCount
            {
                get
                {
                    throw new NotImplementedException();
                }
                set
                {
                    throw new NotImplementedException();
                }
            }

            public TimeSpan FixedIntermediateDelay
            {
                get
                {
                    throw new NotImplementedException();
                }
                set
                {
                    throw new NotImplementedException();
                }
            }

            public TimeSpan MaximumRandomIntermediateDelay
            {
                get
                {
                    throw new NotImplementedException();
                }
                set
                {
                    throw new NotImplementedException();
                }
            }

            public bool ShowArtistColumn { get { return false; } set { } }

            public bool ShowAlbumColumn { get { return false; } set { } }

            #endregion
        }

        internal static AdditionalChoiceData ReadAdditionalData(System.Xml.XmlReader reader)
        {
            AdditionalChoiceData data = new AdditionalChoiceData();
            data.FixedStartDelay = TimeSpan.FromMilliseconds(reader.GetIntegerAttribute("FixedStartDelay"));
            data.MaximumRandomStartDelay = TimeSpan.FromMilliseconds(reader.GetIntegerAttribute("RandomStartDelay"));
            data.FixedIntermediateDelay = TimeSpan.FromMilliseconds(reader.GetIntegerAttribute("FixedInterDelay"));
            data.MaximumRandomIntermediateDelay = TimeSpan.FromMilliseconds(reader.GetIntegerAttribute("RandomInterDelay"));
            data.RepeatCount = reader.GetIntegerAttribute("RepeatCount");
            if (reader.IsEmptyElement)
            {
                reader.Read();
            }
            else
            {
                reader.Read();
                reader.ReadInnerXml();
                reader.ReadEndElement();
            }
            return data;
        }

        internal BackgroundSounds(System.Xml.XmlReader reader)
            : base(reader)
        {
            m_Elements = new List<IBackgroundSoundChoice>();
            int id = reader.GetIntegerAttribute("ContainerId");
            m_Container = DataModule.TheElementFactory.CreateParallelContainer(Title + "_Parallel", id);

            if (reader.IsEmptyElement)
            {
                XmlHelpers.ThrowException(StringResources.ExpectedContent, reader);
            }
            reader.Read();
            while (reader.IsStartElement())
            {
                if (reader.IsStartElement("SubElements") && !reader.IsEmptyElement)
                {
                    reader.Read();
                    while (reader.IsStartElement())
                    {
                        if (reader.IsStartElement("BackgroundSoundChoice"))
                        {
                            BackgroundSoundChoice choice = new BackgroundSoundChoice(reader);
                            IParallelElement parallelElement = m_Container.AddElement(choice);
                            parallelElement.RepeatCount = -1;
                            choice.ParallelElement = parallelElement;
                            if (reader.IsStartElement("ParallelElementData"))
                            {
                                AdditionalChoiceData data = ReadAdditionalData(reader);
                                parallelElement.FixedStartDelay = data.FixedStartDelay;
                                parallelElement.MaximumRandomStartDelay = data.MaximumRandomStartDelay;
                                parallelElement.FixedIntermediateDelay = data.FixedIntermediateDelay;
                                parallelElement.MaximumRandomIntermediateDelay = data.MaximumRandomIntermediateDelay;
                                parallelElement.RepeatCount = data.RepeatCount;
                            }
                            m_Elements.Add(choice);
                        }
                        else
                        {
                            reader.ReadOuterXml();
                        }
                    }
                    reader.ReadEndElement();
                }
                else
                {
                    reader.ReadOuterXml();
                }
            }

            reader.ReadEndElement();
        }        

        private List<IBackgroundSoundChoice> m_Elements;
        private IElementContainer<IParallelElement> m_Container;
    }
}
