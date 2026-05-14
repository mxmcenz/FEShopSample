# 🚀 FEShop - Product Management API

Минималистичный CRUD-сервис на **FastEndpoints** и **Clean Architecture**.

## 🛠 Технологии
*   **Backend:** .NET 8, FastEndpoints, EF Core 8
*   **Database:** PostgreSQL 17
*   **DevOps:** Docker, Docker Compose

## 🏗 Архитектура
*   **Clean Architecture:** Четкое разделение на Domain, Application, Infrastructure и WebApi.
*   **Vertical Slices:** Каждая фича (Create, Get, Update, Delete) инкапсулирована в своей папке.

## 🚦 Быстрый старт

Swagger будет доступен по адресу: http://localhost:5555/swagger

```bash
# 1. Склонируйте проект
git clone https://github.com/ваш-логин/FEShop.git

# 2. Запустите всё одной командой (база + API)
docker-compose up -d --build
