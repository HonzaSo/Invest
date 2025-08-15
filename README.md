# Invest App – Dokumentace projektu

Tento dokument shrnuje architekturu projektu Invest, včetně jednotlivých projektů, datové vrstvy, migrací a konfigurace připojení k databázi PostgreSQL.

---

## 🧩 Projekty ve Solutionu

Projekt je rozdělen do následujících částí:

| Projekt               | Popis                                                                 |
|-----------------------|-----------------------------------------------------------------------|
| **Invest.Api**        | API vrstva – definice endpointů, komunikace s klientem               |
| **Invest.Application**| Aplikační logika – služby, příkazy, dotazy, business pravidla        |
| **Invest.Domain**     | Doménové modely – entity, rozhraní, výčty, základní pravidla         |
| **Invest.Infrastructure** | Datová vrstva – přístup k databázi, konfigurace EF Core, migrace |
| **Invest.Web**        | Webová aplikace – vstupní bod, konfigurace DI, hostování             |
| **Invest.Tests**      | Testy – jednotkové a integrační testy                                |

---

## 🧱 Migrace v EF Core

Migrace se generují pomocí EF Core CLI:

```bash
dotnet ef migrations add InitialCreate --project Invest.Infrastructure --startup-project Invest.Web --output-dir DataAccess/Migrations
dotnet ef database update --project Invest.Infrastructure --startup-project Invest.Web


