
## Avaliação Técnica para a Secretaria de Saúde 

 

## Atividade: Realizar o desenvolvimento de um Sistema de Cadrastro de usuário, em formato de CRUD. 



---
Esse projeto é um sistema de cadrastro de usuários!

---

### Métodos

A pagína web foi desenvolvida utilizando a linguagem C#, ASP.NET Core MVC, utilizando o método CRUDS para fazer a requisições
ao banco de dados SQL Server.

#### `[GET]` /Usuarios/create
#### `[POST]` /Usuarios/create
#### `[GET]` Usuarios/Edit
#### `[POST]` Usuarios/Edit
#### `[GET]` Usuarios/Delete
#### `[POST]` Usuarios/Delete

---

### Funcionalidaes

<body>
<ol>
<li>Cadastrar Usuário</li>
<li>Editar os dados cadastrais do Usuário</li>
<li>Verificar os detalhes do cadastro;</li>
<li>Deletar um Usuário.</li>
</ol>
</body>


### Arquitetura do projeto - MVC

```
MVC
📂 
├─ 📂 DesafioScSaude
|  ├─Connected Services
|  ├─Dependências
│  ├─ 📂Prorerties
│  ├─ wwwroot
│  ├─ 📂 controllers
│  │  └─ HomerController.cs
│  │  └─ UsuariosController.cs
│  ├─ 📂Migrations
│  ├─ 📂 models
│  │  └─ Contexto.cs
│  │  └─ ErrorViewModel.cs
|  |  └─ Usuario.cs
|  ├─ 📂 Views
│  │  └─📂 Home
│  ├  └─📂 Shared
│  │  └─📂 Usuarios
│  ├
│  └─ appsettinsgs.json
│  └─ Program.cs
│  
├─ README.md


```
---

### Tecnologias utilizadas

| Tecnologias Utilizadas |
| ---------------------- |
| C#                     |
| GitHub                 |
| JavaScript             |
| SQL Server             |
| CSS/HTML               |
| VS                     |

---


### Dependências

|   Dependência      | Versão |
| -------------------| ------ |     
| Enity Frameworkcore| >= 8   |


