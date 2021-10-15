# Proiect_AE_Master
## Proiect seminar Afaceri Electronice - master BDSA an 2

Pentru a rula acest proiect, avem urmatorii pasi:
1) Baza de date SQL: se deschide SSMS si se da comanda Import Data-tier Application pentru fisierul Puzzle4U_SQL_data.bacpac
Se verifica daca numele bazei de date este scris corect (Puzzle4UbyNAM) - daca nu, se redenumeste
In appsettings.json se va modifica conexiunea la server (momentan este Server=ANDREEAHP\\SQLEXPRESS); baza nu are setari de login
2) Se deschide solutia in VS 2019 (sistemul isi va face upgrade automat la repository - pentru .NET Core 5.0 etc.)

Aplicatia dispune de sistem complet de inregistrare/autentificare, implementandu-se 3 nivele de acces:
1) Guest - care poate vedea produsele de pe pagina principala si butoanele pentru Login si Register (pentru orice alta actiune i se cere Login; exemplu: Add to basket)
2) Utilizator - inregistrat/autentificat; are acces peste tot, mai putin la paginile de configurare. Exista buton de Remember me (cu bifa), precum si buton de Logout.
La inregistrare se aplica validari de complexitate pentru parola si format email.
In partea de jos a ecranului (in aplicatie) se poate vedea "Logged as - nume-utilizator"
3) Admin - are acces peste tot. Cont unic, setat in aplicatie: admin@puzzle4u.ro cu parola Alina#11


Posibilitati de imbunatatire la nivel de arhitectura:
- Implementare in stanga a unei liste dinamice pentru brand si type cu posibilitate de selectare check (filtrare)
- Adaugare de filtre noi
- Implementare sistem de paginatie (cu numar fix sau setat de utilizator pentru afisarea rezultatelor) si navigare (dintr-o pagina in alta)
- Adaugare posibilitate de a modifica date utilizator (login)
- Implementare solutie de validare email cu cod
- Implementare finalizare comanda si buton de istoric comenzi (History orders)
- Adaugare de functionalitati pentru administrator, cum ar fi rapoarte (ssrs) pentru analiza produse vandute pe luna etc.
- Implementare completa pe roluri pentru acces la setari si aplicatie folosind asp.net framework
