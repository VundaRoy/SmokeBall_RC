Smokeball top 100 list

This is a Smokeball assignment task that seeks to extract the list of occurences of the 
Smokeball url site from the top 100 site searches.
I have created 3 projects for this task, which includes 

Smokeball.Desk - The main WPF application
Smokeball.BLL - The business logic class library 
Smokeball.Test - Unit test project.

Some thoughts..

Due to time constraints a few things came to mind about design and going forward.
I have tried to incorporate the spirit of OO in much of the design layout with emphasis
on preserving separation of concerns as much as I can implement.
On the flexibility side there can be improvements such as having a UI to maintain the app.config
constant variables such as the Url, top count and search criteria. Currently GetWebResults.cs 
(in Smokeball.Desk project under the VM directory) reads from the app.config to get those constant variables.

I would have liked to invest more time in getting better UI design as well as having a more MVVM
like design outcome. My primary motive  was to getting a working solution which is as
easy to maintain in the future and hopefully more scalable.
