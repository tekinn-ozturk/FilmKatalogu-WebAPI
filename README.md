## API Endpoints

API, aşağıdaki CRUD operasyonlarını gerçekleştirir:

- **Film İşlemleri:**
  - `GET /api/Film/TumFilmleriGetir`: Bütün filmleri getirir.
  - `GET /api/Film/IdyeGoreFilmGetir/id`: Verilen Id'ye ait bir filmi getirir.
  - `POST /api/Film/FilmEkle`: Yeni bir film ekler.
  - `PUT  /api/Film/FilmGuncelle/id`: Verilen Id'ye ait filmi günceller.
  - `DELETE /api/Film/FilmSil/id`: Verilen Id'ye ait filmi siler.

- **Kategori İşlemleri:**
  - `GET /api/Kategori/TumKategorileriGetir`: Bütün kategorileri getirir.
  - `GET /api/Kategori/IdyeGoreKategoriGetir/id`: Verilen Id'ye ait bir kategoriyi getirir.
  - `POST /api/Kategori/KategoriEkle`: Yeni bir kategori ekler.
  - `PUT /api/Kategori/KategoriGuncelle/id`: Verilen Id'ye ait bir kategoriyi günceller.
  - `DELETE /api/Kategori/KategoriSil/id`: Verilen Id'ye ait kategoriyi siler.

- **Oyuncu İşlemleri:**
  - `GET /api/Oyuncu/TumOyunculariGetir`: Bütün oyuncuları getirir.
  - `GET /api/Oyuncu/IdyeGoreOyuncuGetir/id`: Verilen Id'ye ait bir oyuncuyu getirir.
  - `POST /api/Oyuncu/OyuncuEkle`: Yeni bir oyuncu ekler.
  - `PUT /api/Oyuncu/OyuncuGuncelle/id`: Verilen Id'ye ait bir oyuncuyu günceller.
  - `DELETE /api/Oyuncu/OyuncuSil/id`: Verilen Id'ye ait oyuncuyu siler.
