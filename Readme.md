Use Case #1 emerges as a robust and dynamic tool crafted meticulously in the .Net Core environment, 
designed to simplify data management and retrieval processes concerning a comprehensive list of countries. 
Users can effortlessly load an extensive list of countries, leveraging the streamlined functionality to filter it by distinctive attributes such as name and population. 
What sets it apart is its capability to not only curate information but also to refine results to an appreciable extent, facilitating a smooth, user-friendly experience. 
The potent feature of sorting and limiting results using values provided by an API grants users the flexibility to tailor their data output according to their specific requirements.

In the contemporary digital landscape, efficiency and precision are key; 
Use Case #1 is a testament to both. Every query culminates in results formatted as JSON, 
ensuring seamless integration and interpretation of data across various platforms and systems. 
This application stands as an indispensable tool for analysts, developers, and data enthusiasts who are on the hunt for a reliable, 
fast, and effective way to sift through and organize vast arrays of country-related data. Embark on a journey of streamlined data management with Use Case #1, 
where functionality meets innovation in a perfect blend.

Pre-requisites:
1. .NET Core SDK: Ensure you have the .NET Core SDK installed on your machine.
2. Code Editor: Have a code editor such as Visual Studio, Visual Studio Code, or any preferred editor installed.
Step 1: Set Up Your Environment
Open your terminal or command prompt and navigate to the directory where .NET Core project is located.

Step 2: Restore Dependencies
Before you run the application, make sure to restore all the necessary dependencies. You can do this by running the following command in the terminal:

dotnet restore

Step 3: Build the Application
Build application to check for any compilation errors. Use the following command to build the application:

dotnet build

Step 4: Run the Application
After building the application successfully, run the application using the following command:

dotnet run

This command will start the application. It's a web application, use a local URL (like http://localhost:5000) which you can navigate to in a web browser to use application.

Step 5: Accessing the Application
As mentioned, open your web browser and access the application using the provided local URL.

(Optional) Step 6: Use an IDE
If you are using an IDE like Visual Studio, you can open the project file (.csproj) in the IDE, and use the built-in tools to run and debug the application locally. Usually, there is a "Run" or "Debug" button in the toolbar for this purpose.


Here are 11 examples of API usage:

Example 1: Fetching All Countries
You could start by simply getting a list of all countries without any filters:

GET http://localhost:5000/api/country

Example 2: Fetching Countries with Population Less than 1 Million

GET http://localhost:5000/api/country?populationThreshold=1

Example 3: Fetching the Top 5 Countries by a name

GET http://localhost:5000/api/country?amount=5&order=ascend

Example 4: Fetching Countries with Common Name Partially Matching "stan"

GET http://localhost:5000/api/country?commonNamePartial=stan

Example 5: Fetching 10 Countries with Population Less than 10 Million, Ordered by Name

GET http://localhost:5000/api/country?populationThreshold=10&amount=10&order=ascend

Example 6: Fetching 15 Countries with Common Name Partially Matching "land", Ordered by Name

GET http://localhost:5000/api/country?commonNamePartial=land&amount=15&order=ascend

Example 7: Fetching the Top 3 Countries with Population Less than 50 Million, Ordered by Name in Descending Order

GET http://localhost:5000/api/country?populationThreshold=50&amount=3&order=descend

Example 8: Fetching Countries with Common Name Partially Matching "repub", Limited to 5 Results

GET http://localhost:5000/api/country?commonNamePartial=repub&amount=5

Example 9: Fetching 10 Countries with Population Less than 5 Million, Ordered by Name in Descending Order

GET http://localhost:5000/api/country?populationThreshold=5&amount=10&order=descend

Example 10: Fetching the Top 20 Countries with Common Name Partially Matching "island", Ordered by Name

GET http://localhost:5000/api/country?commonNamePartial=island&amount=20&order=ascend

Example 11: Fetching 7 Countries with Population Less than 100 Million, Ordered by Name in Descending Order

GET http://localhost:5000/api/country?populationThreshold=100&amount=7&order=descend