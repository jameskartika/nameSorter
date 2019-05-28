# nameSorter
Name Sorter made using C# .NET CORE for GlobalX coding assignment</br>
Make sure to have .NET CORE installed.

Program will output a txt file in the GlobalX directory called sorted-names-list.txt

# Build & Run Instructions
To run, be on the GlobalX directory, then do
```
dotnet build name-sorter
dotnet run --project name-sorter ./[FILENAME]
```
make sure to put the file in the GlobalX folder, the same directory as the example file. Or you can change the path.


If you want to run the sample file given,
```
dotnet run --project name-sorter ./unsorted-names-list.txt
```

# unit testing Instructions
To do unit testing, do
```
dotnet build XUnitTest_name-sorter
dotnet test XUnitTest_name-sorter
```
