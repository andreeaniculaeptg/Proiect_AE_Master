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
La inregistrare se aplica validari de complexitate pentru parola si format email
3) Admin - are acces peste tot. Cont unic, setat in aplicatie: admin@puzzle4u.ro cu parola Alina#11
