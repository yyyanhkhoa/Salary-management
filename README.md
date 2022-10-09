# Salary-management
Se100


## Requirements:
This program uses Postgresql to store data.

Download and install Postgresql: https://www.postgresql.org/download/ 

**!! While installing postgresql, set your superuser's username and password to 'postgres' or you'll have to manually change the connection string for this program to run !!**

## Setup
1. Clone this repository: run `git clone https://github.com/yyyanhkhoa/Salary-management.git` and `cd Salary-management`

2. Install dependency packages: run `dotnet restore`

3. Create the database on your local machine: run `dotnet ef database update`

4. Build and run the app

## To change the connection string
1. Create file named "connection-string.txt" in the project root

2. Write your connection string inside the file, example: `Host=localhost;Database=SalaryMan;Username=postgres;Password=postgres`
