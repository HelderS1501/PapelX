<div align="center">
  <img src="./Doc/img/PapelX-Logo1_White.png" alt="PapelX Logo" width="500" height="285" />
</div>

---

## 🗺️ *Roadmap Project (Backend)*
- [x] Initial folder structure and repository configuration
- [x] Implement database in-memory
- [ ] CRUD for Products (`feat/create`, `feat/list`, etc.)
- [ ] Merge to develop
- [ ] Merge to staging
- [ ] Merge to main
- [ ] Go live in production

---

# ✏️ *PapelX - Stationery Management*

**PapelX** is a management system for stationery stores that exposes a robust API for product control (pens, notebooks, paper). The project was developed using CRUD concepts, is minimalist and focused on objectivity, but prepared for scalability, simplicity of execution and well-structured; the entire backend was built in C# with .NET v10 and the ASP.NET Core Framework.

## 🛠️ *Technologies and Tools Used*

* **Language:** C# v14, .NET v10
* **Framework:** ASP.NET Core WebAPI
* **IDE:** Visual Studio Code
* **Architecture:** Clean, monolithic architecture (It was designed and prepared for horizontal scaling.)
* **Database:** In-Memory

## 📐 *Project Structure*

The ecosystem is divided to ensure separation of responsibilities:
* **PapelX.WebApi:** Single layer that exposes the API endpoints.

## 🚀 *How to Execute the Project*

### *Prerequisites*
* .NET 10 SDK installed locally.
* Text editor or IDE of your choice.

### *step by step*

1. **Clone the repository:**
   ```text
   git clone https://github.com/HelderS1501/PapelX.git
   cd PapelX
   ```

2. **Run the Application:**
   ```text
   dotnet run --project src/PapelX.WebApi/PapelX.WebApi.csproj
    ````

3. **Open in Browser:**
    ```text
    The API will start locally. You can access interactive documentation for the endpoints via Scalar through: http://localhost:5000/scalar
    ```
### 📌 *Key CRUD Endpoints*

#### 📦 *Products (Materials, Notebooks, Office Supplies)*

**GET** ```/v1/produtos``` - List all products available at the stationery store.

**GET** ```/v1/produtos/{id}``` - Retrieves the details of a specific item by its ID.

**POST** ```/v1/produtos``` - Register a new product

**PUT** ```/v1/produtos/{id}``` - Updates the information for an existing item.

**DELETE** ```/v1/produtos/{id}``` - Remove the product from the stationery store catalog.
