# Requirements Document 
## 1 Introduction
Cross-platform mobile application for view of train routes.
## 2 User Requirements
### 2.1 Software Interfaces
#### Used technologies
- Xamarin - a framework for cross-platform mobile application solutions (iOS, Android, Windows Phone) using C#.
- Azure Server to store needed information.
### 2.2 User Interfaces
User interface will provide facilities on the selected a needed cities and picking a date for the departure of the train.
User will see all routes which are possible at this time.
### 2.3 User characteristics
This application will be made for all categories of people from 10 years old.
### 2.4 Assumptions and Dependencies
- Сonvenient, easy gui;
- Easy extensibility and changeability of content
# System requirements
The application will support versions of android 5.0 and above, and IOS 9 and above.
### 3.1 Functional Requirements
1. Ability to select needed city.
2. Ability to display a list of all routes.
3. Ability to display available tickets.
4. Ability to choose the day the train was sent.
5. Ability to browse cache tickets without network connection.
6. Ability to order a ticket (not necessary) 
### 3.2 Non-Functional Requirements
- Performance - people don't want to wait for many time while page is loading. To avoid wasting precious time user must wait maximum 5 second to load any page on app. Measures in time needed to load web page.
- Reability - the web app must be deployed 24 hours per day without troubles to access it. Important because users must know that they can use resource of web app any time they need it. 
- Ьultilanguage of content in languages: Russian and English - because often website is visited by users from other countries. Measures in part of content which has both russian and english languages.
# Analogs
1. Android app "Чыгунка"
