# Stock-Search

<b> Task Brief </b>

This project asked me to design and implement a Search and Sort application in C#. In particular,  I needed to create a Console Application, which will help with the analysis of share prices. This assignment had mandatory (1-3) and additional (4-7) tasks, which allowed me to achieve higher marks.

A set of files was provided: “Close_128.txt”, “Change_128.txt”, “Open_128.txt”, “High_128.txt”, “Low_128.txt”, “Close_256.txt”, “Change_256.txt”, “Open_256.txt”, “High_256.txt”, “Low_256.txt”, “Close_1024.txt”, “Change_1024.txt”, “Open_1024.txt”, “High_1024.txt”, and “Low_1024.txt”.

The files corresponded to real share prices of a major bank taken from the London Stock Exchange. The Close_*.txt, Open_*.txt, High_*.txt, Low_*.txt, and Change_*.txt respectively corresponded to the Close, Open, High, and Low prices of the stocks, as well as their Percentage Change of share value traded on the day. The 128, 256 and 1024 numbers corresponded to the number of stocks stored in the files.

I had to initially, read the files “Close_128.txt”, “Change_128.txt”, “Open_128.txt”, “High_128.txt”, and “Low_128.txt” into individual Arrays.

The Console Application then needed to be able to provide the following functionality to the user:
1. Select which individual Array is to be analysed.
2. Sort in ascending or descending order and display the selected Array.
3. Search the selected Array for a user-defined value, if the value exists, then provide its location
(if it appears more than once then provide ALL the locations) otherwise, provide an error message.
4. Repeat the previous task, but if the value does not exist then provide the value(s) and location(s) of its nearest value. 
5. Your Console Application should be in the position to input the files with length 256 and 1024. Then repeat Tasks 2 to 4 and display the corresponding values for all the selected arrays.
6. For additional marks, Merge the Close_128.txt and High_128.txt files. Then repeat Tasks 2 to 4 and display the corresponding values.
7. For top marks repeat task 6 using the files with length 256 and 1024.

We were NOT allowed to use any built-in sorting and searching functions from any built-in or external C# library.



