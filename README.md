# Structural_DesignPatterns
•	Modelul Adapter:
Ajută la transformarea interfeței unei clase într-o altă interfață în funcție de cerințele clientului. Deci, practic, oferind ceea ce este cerut de client prin utilizarea serviciului unei clase cu o interfață diferită. Modelul adaptorului este cunoscut și sub numele de Wrapper.
•	Composite:
Clientul este capabil să opereze obiecte care pot reprezenta sau nu ierarhia acestuia. În termeni simpli, modelul compozit vă permite să creați un arbore ierarhic cu complexități unice, care permite tratarea fiecărui obiect individual.
•	Decorator Pattern:
Putem adăuga sau elimina funcționalitatea obiectului fără a modifica funcția sau aspectul exterior al obiectului. Prin urmare, cu ajutorul unui model de decorator, putem adăuga responsabilități suplimentare unui obiect fără a modifica funcționalitățile obiectului.
•	Facade Pattern:
Oferim o interfață simplificată unui set de interfețe ale unui subsistem pentru a ascunde complexitatea subsistemului de client. Cu cuvinte simple, cu ajutorul modelului de fațadă, facem subsistemele mai ușor de utilizat prin descrierea unei interfețe de nivel superior.
•	Flyweight Patterns:
Ne ajută să reutilizam tipuri similare de obiecte existente prin stocarea și crearea de noi obiecte atunci când obiecte similare nu sunt găsite. Prin urmare, în termeni simpli, ne ajută să reducem costul mai multor instanțe care conțin aceleași date.
•	Proxy Pattern:
Oferim un substituent sau un obiect surogat pentru a controla accesul la obiectul original. În termeni simpli, furnizarea unui proxy sau un strat inactiv de informații înaintea clientului înainte de a accesa datele originale.


In acest proiect am utilizat doua design pattern-uri structurale: Adapter si Decorator.: Decorator și Adapter.
# Decorator Pattern:
Decorator pattern este utilizat pentru a adăuga dinamic funcționalitate suplimentară la interfața ‘IVehicle’ în timpul rulării. Interfața ‘IVehicleDecorator’ extinde interfața ‘IVehicle’, iar clasele ‘GpsDecorator’ și ‘MusicDecorator’ implementează interfața ‘IVehicleDecorator’. Aceste clase primesc o instanță de ‘IVehicle’ în constructorul lor și redirecționează apelurile către metoda ‘Rent’ către obiectul decorat. Acestea adaugă apoi comportament suplimentar înainte sau după apelul metodei ‘Rent’ a obiectului decorat.
# Adapter Pattern:
Adapter pattern este utilizat pentru a adapta o interfață ‘IThirdPartyRentalService’ de la terțe părți la interfața ‘IVehicle’ utilizată de restul codului. Clasa ‘ThirdPartyRentalAdapter’ implementează interfața ‘IVehicle’ și primește o instanță de ‘IThirdPartyRentalService’ în constructorul său. Când este apelată metoda ‘Rent’ pe ‘ThirdPartyRentalAdapter’, aceasta este transformată și apelată metoda ‘RentCar’ pe obiectul ‘IThirdPartyRentalService’.

