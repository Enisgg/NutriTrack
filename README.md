# NutriTrack

A desktop nutrition and fitness tracking application built with C#, .NET, Avalonia UI, SQLite, and Entity Framework Core.

## Overview

NutriTrack helps users track their personal fitness journey by managing profile information, recording meals, monitoring weight progress, and viewing nutrition statistics.

The application was developed using the MVVM (Model-View-ViewModel) architectural pattern and stores data locally using SQLite.

---

## Features

### User Profile Management
- Create and save user profiles
- Store personal information such as:
  - Name
  - Weight
  - Height
  - Sex
  - Fitness Goal

### Meal Tracking
- Add meals to the database
- Store nutritional information:
  - Calories
  - Protein
  - Carbohydrates
  - Fat
- View saved meals
- Delete meals

### Weight Tracking
- Record weight entries
- Store historical weight data
- Monitor progress over time

### Dashboard
- Display total calories consumed
- Display total protein intake
- Display total carbohydrates intake
- Display total fat intake

### Database Integration
- SQLite local database
- Entity Framework Core ORM
- Persistent data storage

---

## Technologies Used

- C#
- .NET 9
- Avalonia UI
- SQLite
- Entity Framework Core
- CommunityToolkit.Mvvm
- MVVM Architecture

---

## Architecture

The application follows the MVVM design pattern:

```text
View
 ↓
ViewModel
 ↓
Entity Framework Core
 ↓
SQLite Database
```

This architecture separates the user interface, business logic, and data access layers, making the application easier to maintain and extend.

---

## Project Structure

```text
Models/
    User.cs
    Meal.cs
    WeightEntry.cs

Database/
    NutritionDbContext.cs

ViewModels/
    MainWindowViewModel.cs
    UserViewModel.cs
    MealViewModel.cs
    DashboardViewModel.cs
    WeightViewModel.cs

Views/
    MainWindow.axaml
    UserView.axaml
    MealView.axaml
    DashboardView.axaml
    WeightView.axaml
```

---

## Screenshots

### Main Menu

<img width="1470" height="956" alt="Screenshot 2026-06-24 at 10 32 37" src="https://github.com/user-attachments/assets/d59c48c2-9ef1-4473-af04-96633c878977" />


### User Profile

<img width="1470" height="956" alt="Screenshot 2026-06-24 at 10 32 56" src="https://github.com/user-attachments/assets/95934d4a-f251-45cc-8526-d15b36fac966" />


### Meal Tracking

<img width="1470" height="956" alt="Screenshot 2026-06-24 at 10 33 01" src="https://github.com/user-attachments/assets/3c267100-b0c4-4e4d-b17b-f32ebddee09b" />


### Weight Tracking

<img width="1470" height="956" alt="Screenshot 2026-06-24 at 10 33 10" src="https://github.com/user-attachments/assets/8de08b9b-57f1-4e3b-8787-f915d0708764" />


### Dashboard

<img width="1470" height="956" alt="Screenshot 2026-06-24 at 10 33 06" src="https://github.com/user-attachments/assets/290b3232-242d-4fb6-b6a2-2e655fa84751" />


---

## What I Learned

During this project I gained practical experience with:

- Desktop application development using Avalonia UI
- MVVM application architecture
- Database design with SQLite
- Entity Framework Core migrations
- CRUD operations
- Data binding in Avalonia
- Git and GitHub version control

---

## Future Improvements

- Meal editing functionality
- Nutrition API integration
- Weight progress charts
- Dark/Light theme switching
- Multi-user support
- Daily calorie goals and recommendations

---

## Author

**Enis G.**

Software Engineering Student

