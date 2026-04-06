# Task Tracker App (Blazor)
A simple **Task Tracker (To-Do List)** application built with **Blazor Server**.  

## Features:
- Add new tasks
- View all tasks in a table (grid)
- Mark tasks as completed / not completed
- Edit existing tasks
- Delete tasks
- Filter tasks (All / Active / Completed)
- Display count of active tasks
- Validation (prevents empty task titles)

---

## Technologies Used

- ASP.NET Core Blazor Server (Component - based architecture)
- C#
- Razor Components (.razor)
- Dependency Injection (DI)
- In-memory data storage (no database)
- Bootstrap (basic styling)

---

Tasks are stored in an in-memory list
TaskService manages all task operations
Dependency Injection is used to provide the service to components
UI is built using Blazor components and data binding
