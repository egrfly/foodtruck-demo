# foodtruck-demo

This solution is intended to demonstrate core MVC concepts using a food truck analogy.

## Requirements

The solution uses ASP.NET Core 6.0 and PostgreSQL.

## Setup

Firstly, create a PostgreSQL user called `foodtruck` with the password `foodtruck` and with permission to log in.

Secondly, inside the cloned solution, run the following command to ensure all dependencies are installed:

```bash
$ dotnet restore
```

Thirdly, from the root of the solution, run the following commands to move into the `FoodTruck` project and prepare the database:

```bash
$ cd FoodTruck
$ dotnet ef database update
```

## Running the project

If you are not already inside the `FoodTruck` project, run the following command from the root of the solution to move into it:

```bash
$ cd FoodTruck
```

Once you are inside the `FoodTruck` project, use the following command to run it:

```bash
$ dotnet run
```

## Running the tests

If you are not already inside the `FoodTruckTest` project, run the following command from the root of the solution to move into it:

```bash
$ cd FoodTruckTest
```

Once you are inside the `FoodTruckTest` project, use the following command to run the tests within:

```bash
$ dotnet test
```
