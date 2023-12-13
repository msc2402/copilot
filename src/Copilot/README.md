# Demo

## Refactoring
Implement the [Product](./Business/Product.cs) class
```
Create an implementation of the Product class using the following guidelines:
- Implement all properties from the command
- Use a constructor for creation.
- Ensure the setters are encapsulated.
- Ensure an empty private constructor is added.
- Validate the incoming values before setting them
- #file:Product.cs
- #file:CreateProductCommand.cs
- #file:ICreateProductSpec.cs
```

## Unit tests
Create unit tests for the [Product](./Business/Product.cs) class
```
Create a unit test in the Copilot.Tests project for the Product class using the following guidelines:
- #file:Product.cs
- #file:Copilot.Test.csproj
```

## Convert data annotations to fluent validation.
```
Create a Fluent Validator class for the CreateProductCommand class using the following guidelines:
- Inherit the AbstractValidator class
- Ensure all properties are validated using the rules of the annotations already present on the command.
- #file:CreateProductCommand.cs
```

## Code explanation and simplifying
Explain the code in the [Extensions](./Application/Extensions.cs) class
```
Explain the selected code and suggest a simplification.
```

## Code implementation
Implementing the [ProductService](./Application/ProductService.cs) class
```
Implement the ProductService class using the following guidelines:
- Make sure the return types are used and properties are set.
- #file:ProductService.cs
- #file:Product.cs
- #file:ProductModel.cs
- #file:ProductRepository.cs
```

## JSON translation and ordering
Translate and order [translations.json](./translations.json)
```
Create a new translation file 
Translate all values in this file to english. Do not translate the keys. 
Sort alphabetically by the keys in ascending order.
```

## Commit messages (VS preview versie)


## Copilot voice
```
https://githubnext.com/projects/copilot-voice/
```