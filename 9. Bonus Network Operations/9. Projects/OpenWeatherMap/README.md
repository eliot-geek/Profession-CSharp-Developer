## Task: The task involves creating a C# program that retrieves weather information from the OpenWeatherMap API and displays the temperature in Celsius for a specified location. 

The program should also be able to handle potential errors gracefully. Here are the main components of the task:

1. Use the OpenWeatherMap API: The program should make an HTTP request to the OpenWeatherMap API to fetch weather data for a specific location.
2. The API endpoint to use is `https://api.openweathermap.org/data/2.5/weather`. The location should be passed as a parameter to the function `GetTemperature`.  
3. Input Location: The program should allow the user to specify a location for which they want to retrieve weather information. The location can be a city name or a place of interest.  
4. Handle Errors: The program should be able to handle potential errors, such as invalid locations or network issues. If an error occurs during the API request, the program should return "Error."  
5. Display Temperature: After successfully fetching the weather data, the program should extract the temperature in Celsius from the JSON response and display it to the user.  
6. Test Data: The code currently includes a call to `GetTemperature("Guinea")`. You can test the program with different locations to ensure it retrieves and displays the temperature correctly.  
7. Optional: The code also contains commented-out XML processing logic. You can complete this part of the task to process XML data, but it is not a primary requirement.  
8. Clean Code: Ensure the code is well-structured and follows best practices for error handling and API requests.

The task aims to create a functional weather information retrieval program that can be used to obtain temperatures for various locations through the OpenWeatherMap API.  
