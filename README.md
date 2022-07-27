# Best Restaurants

#### By _Seung Lee_

#### _A simple website that._

## Technologies Used

* _C#_
* _Razor_
* _HTML_
* _CSS_
* _Bootstrap_
* _MySQL_
* _Entity_

## Description

A simple website where a user can .

## Setup/Installation Requirements

_Requires console application such as Git Bash, Terminal, or PowerShell_

1. Open Git Bash or PowerShell if on Windows and Terminal if on Mac
2. Run the command

    ``git clone https://github.com/leark/BestRestaurants.Solution.git``

3. Run the command

    ``cd BestRestaurants.Solution``

* You should now have a folder `BestRestaurants.Solution` with the following structure.
    <pre>BestRestaurants.Solution
    └── BestRestaurants</pre>

4. Add a file named appsettings.json in the following location 

    <pre>BestRestaurants.Solution
    └── BestRestaurants
        ├── Controllers
        ├── ...
        └── <strong>appsettings.json</strong></pre>

5. Copy and paste below JSON text.

```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=best_restaurants;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE]"
  }
}
```

6. Replace [YOUR-USERNAME-HERE] with your MySQL username.

7. Replace [YOUR-PASSWORD-HERE] with your MySQL password.


<strong>To Run</strong>

Navigate to the following directory in the console
   <pre>BestRestaurants.Solution
   └── <strong>BestRestaurants</strong></pre>

Run the following command in the console

  ``dotnet build``

Then run the following command in the console

  ``dotnet run``


This program was built using _`Microsoft .NET SDK 5.0.401`_, and may not be compatible with other versions. Your milage may vary.

## Known Bugs

* _No known issues_

## License

[GNU](/LICENSE)

Copyright (c) 2022 Seung Lee




