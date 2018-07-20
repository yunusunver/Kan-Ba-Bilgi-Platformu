# Bağışçı (Blood Donor)

| Route | HTTP Verb | POST Body | Description |
| :---         |     :---:      |          ---: | :---         |
| /Bagisci/Index  | GET            | Empty         | Home Page |
| /Bagisci/HayatKurtar  | GET            | Empty         | Blood donor form. |
| /Bagisci/HayatKurtar     | POST       |  	{ TcNo:12345678912, 'Ad':'Ali', 'Soyad':'Veli','EPosta':'ali@gmail.com' 'Telefon':"05550060617", 'KanGrubu': 'A+','Sehir':'Ankara','Tarih':'20.07.2018' }      | Create a blood donor information form.     |
| /Bagisci/BagisciBilgileri  | GET            | Empty         | List all blood donors.   |
| /Bagisci/About  | GET            | Empty         | About Page |
| /Bagisci/Contact  | GET            | Empty         | Contact Page |



# Hasta (ill)

| Route | HTTP Verb | POST Body | Description |
| :---         |     :---:      |          ---: | :---         |
| /Bagisci/KanIhtiyaci  | GET            | Empty         | List all patients |
| /Bagisci/AnonsGec  | GET            | Empty         | Patient form. |
| /Bagisci/AnonsGec     | POST       |  	{ TcNo:12345678912, 'Ad':'Ali', 'Soyad':'Veli','EPosta':'ali@gmail.com' 'Telefon':"05550060617", 'KanGrubu': 'A+','Hastane':'Atatürk Hastanesi','Sehir':'Ankara','Tarih':'20.07.2018' }      | Create a patient information form.     |


