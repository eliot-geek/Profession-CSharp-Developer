# NoteBook / Address book

## Instructions

The program asks the user for contact information:

- Full Name
- Street
- House Number
- Apartment Number
- Mobile Phone
- Home Phone

Using `XElement`, create an XML file that contains the entered information. The XML file should have the following structure:

```
    <Person name="Person's Full Name">
        <Address>
            <Street>Street Name</Street>
            <HouseNumber>House Number</HouseNumber>
            <FlatNumber>Apartment Number</FlatNumber>
        </Address>
        <Phones>
            <MobilePhone>75646485859487</MobilePhone>
            <HomePhone>265-7867-321</HomePhone>
        </Phones>
    </Person>
```

## Recommendations
Fill the XElement as you gather the data. Explore XElement capabilities in Microsoft's documentation.

## Evaluation Criteria
The program creates an XML file containing all the contact information.
