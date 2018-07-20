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

# Home Page
![opera anlik goruntu_2018-07-20_083045_localhost](https://user-images.githubusercontent.com/24482512/42986025-aada14bc-8bfc-11e8-88e7-546ce8a997e3.png)
# List a patients
![opera anlik goruntu_2018-07-20_083215_localhost](https://user-images.githubusercontent.com/24482512/42986026-ab01787c-8bfc-11e8-98e9-249084068719.png)
# Create a patient information form.
![opera anlik goruntu_2018-07-20_083302_localhost](https://user-images.githubusercontent.com/24482512/42986027-ab241382-8bfc-11e8-9d23-07b5addd0b5c.png)
