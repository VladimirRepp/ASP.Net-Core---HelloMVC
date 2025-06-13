# ASP.Net-Core---HelloMVC
ASP.NET Core MVC User Management
===

🔹 Проект: Веб-приложение для управления пользователями на ASP.NET Core MVC <br />
🔹 Цель: Демонстрация базового MVC-паттерна (Model-View-Controller) с CRUD-операциями и взаимодействием с базой данных <br />
🔹 Ключевые технологии: <br />
Backend: ASP.NET Core 6+ <br />
Frontend:  <br />
Razor Views <br />
Bootstrap 5 (для стилизации) <br />
JavaScript (для динамических операций) <br />
База данных: не используется  <br />
Архитектура: Классический MVC с четким разделением ответственностей <br />

🔹 Основной функционал:
✅ Просмотр списка пользователей в табличном виде <br />
✅ Добавление/редактирование записей через форму <br />
✅ Удаление с подтверждением (через JavaScript) <br />
✅ Валидация данных на стороне сервера <br />
✅ Динамическое обновление интерфейса <br />

🔹 Структура проекта:
HelloMVC/ <br />
├── Controllers/ <br />
│   └── UserController.cs      # Обработка HTTP-запросов <br />
├── Models/ <br />
│   ├── User.cs                # Модель данных <br />
│   └── UserDbContext.cs       # Контекст БД <br />
├── Views/ <br />
│   └── User/ <br />
│       ├── Index.cshtml       # Список пользователей <br />
│       └── Editor.cshtml     # Форма редактирования <br />
└── appsettings.json           # Конфигурация SQLite <br />

🔹 Отличия от Razor Pages версии:
- Четкое разделение на Controller/View (вместо PageModel)
- Более гибкая маршрутизация через [Route] атрибуты
- Классический подход MVC (без привязки к страницам)

🔹 Возможные улучшения:
- Добавить пагинацию
- Реализовать сортировку в таблице
- Внедрить Identity для аутентификации

🔹 Скриншот интерфейса:
![image](https://github.com/user-attachments/assets/3b16a47a-969e-455d-9ac7-470ace55bbcc)

![image](https://github.com/user-attachments/assets/97d2852e-415c-4075-bcb3-a90156aa4807)

