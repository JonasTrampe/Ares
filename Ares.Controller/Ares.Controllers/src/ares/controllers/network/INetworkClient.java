/*
 Copyright (c) 2010 [Joerg Ruedenauer]
 
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
package ares.controllers.network;

import java.util.List;
import java.util.Map;

import ares.controllers.data.Configuration;
import ares.controllers.data.TitledElement;

public interface INetworkClient {
	
	enum CategoryCombination
	{
		Or,
		CategoryAnd,
		And
	}
	
	void modeChanged(String newMode);
	void modeElementStarted(int element);
	void modeElementStopped(int element);
	void allModeElementsStopped();
	void volumeChanged(int index, int value);
	void musicChanged(String newMusic, String shortTitle);
	void musicListChanged(List<TitledElement> newList);
	void musicFadingChanged(int fadingOption, int fadingTime);
	
	void tagsChanged(List<TitledElement> newCategories, Map<Integer, List<TitledElement>> newTagsPerCategory);
	void activeTagsChanged(List<Integer> newActiveTags);
	void tagSwitched(int tagId, boolean isActive);
	void tagCategoryCombinationChanged(CategoryCombination combination);
	void musicTagFadingChanged(int fadeTime, boolean fadeOnlyOnChange);
	
	void projectFilesRetrieved(List<String> files);
	void configurationChanged(Configuration newConfiguration, String fileName);

	void disconnect();
	void connectionFailed();
	void musicRepeatChanged(boolean isRepeat);
	void musicOnAllSpeakersChanged(boolean onAllSpeakers);
	
	void importProgressChanged(int percent, String additionalInfo);
}
