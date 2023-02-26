# Description

This adds 4 menu items in the "tools" menu bar. Two for a single animation import/export and two for all animation event import/export. Only tested for elden ring.

## !!PLEASE BACKUP ANY FILES THAT ARE IMPORTANT TO YOU (in the project)!!

I haven't tested any edge cases, so just to be safe. I would hate to break something precious to you.

## Single animation import/export

The export function will take all events in the current window and save them to a json file, using the same functionality as copying (Ctrl+c).

The import function will load the json file and **overwrite** all the events in the current window.

## All animation import/export

The export function will take all events from every animation and save them to a json file. It stores it in a nested dictionary: Dictionary<string, Dictionary<long, List<TaeHktEvent.SmallEvent>>>

the first keys are string TAE names

the second keys are long animation ids

and finally a list of the events in a custom format

The import function will load the json file and **overwrite** all the events for which it can match the tae name and animation id. It will take a bit of time.

# Usage

If you want to paste an event to multiple animations with a script, in Python for example.
1. The event params in the json file are not in a readable format (well I can't read them), so we create it how you would normally create an event.
2. Export all animations to json file
3. Get the event you created (because you know the animation id of which it is a part of). You can do this in a script or manually.
4. Append the event to the animation events lists you want, manually or in a script. You can also edit the duration of the events.
5. Not necessary but highly recommended, remove any Tae and animations that you won't change. It speeds up the whole process. Make sure to keep the $type key and value for the dictionaries you keep.

# Improvements

This could do with a lot of improvements, such as not loading into to each animation after updating events, but without this every animation breaks. I'm not sure which part of that function is responsible.

Potentially reducing the size of the json file, and making the parameters readable. If you have any fixes feel free to create an issue or fork it for yourself.
