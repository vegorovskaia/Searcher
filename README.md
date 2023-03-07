# Searcher
MEF-solution
Required to develop extensible C# solution for file searching on a disk.

The solution allows 

- to specify the path to the directory in which the search is performed

- to specify search settings:

- whether to search in subdirectories

- restrictions on attributes, size, date

- to view a dynamically updated (i.e. changing as the search progress) list of search results

- to cancel a search that is running and is currently in progress



The search can be extended using plug-in modules.

- each module corresponds to a specific type of file, for example, .txt, .doc or .xml

- the module implements a UI that allows you to configure conditions specific to the supported type of files that the user wants to search for

- the module implements an algorithm for checking compliance with specified conditions

- connection/disconnection of the module occurs by placing the plug-in in the directory

- connection/disconnection of modules can occur without restarting the program



Only one file type can be searched at a time (i.e. only one extension module works)

One search – only one plug-in works.

Two expansion modules are required:

- required module: search for text files by substring

- module for files of your choice, for example:

- .doc: search by attributes (properties) of office documents

- .xml: search by node value

- .dll: find a managed .NET assembly containing a class that implements a specific interface

- .mp3: search by value from mp3 header

- any other file type



