
## Avaliação Técnica para a Secretaria de Saúde 

 

## Atividade: Realizar o desenvolvimento de um Sistema de Cadrastro de usuário, em formato de CRUD. 



---
Esse projeto é um sistema de cadrastro de usuários!

---

### Pré-requisitos

Antes de começar, você vai precisar ter instalado em sua máquina as seguintes ferramentas:
[Git](https://git-scm.com), SQL server. 
Além disto é bom ter um editor para trabalhar com o código como Visual Studio.

### 🎲 Rodando o Back End (servidor)

```bash
# Clone este repositório
$ git clone <https://github.com/leinane/Avaliacao-Tecnica-Sec-Saude>

# Acesse o projeto pela IDE de sua escolha

# Vá para o arquivo program.cs
$ E mude a string que faz conexão com o banco de dados.

# Para criar a tabela no seu banco de dados, utilize o script de criação de tabela, que está na raiz do projeto ou
execute este comando no terminal:
$ Update-database -Context Contexto

# Execute a aplicação em modo de desenvolvimento
$ F5

# O servidor inciará 
```

### Métodos

A pagína web foi desenvolvida utilizando a linguagem C#, ASP.NET Core MVC e Enity Framework, 
as seguintes requisições são efetuadas no banco de dados SQL Server:

#### `[POST]` Usuarios/create
#### `[POST]` Usuarios/Edit
#### `[POST]` Usuarios/Delete

---

### Testes

Os testes unitarios foram realizados utilizando o framework Xunit
$ Para fazer a execução dos testes, você pode rodar o comando CTRL+R, A. 


---

### Funcionalidaes


- [x] Cadastrar Usuário
- [x] Editar os dados cadastrais do Usuário
- [x] Verificar os detalhes do cadastro;
- [x] Deletar um Usuário.


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
|  └─📂 Repository
|  ├─ 📂 Views
│  │  └─📂 Home
│  ├  └─📂 Shared
│  │  └─📂 Usuarios
|  |
│  ├  
│  └─ appsettinsgs.json
│  └─ Program.cs
|  └─📂 TestProject1
│  
├─ README.md


```
---

## 🛠 Tecnologias
As seguintes ferramentas foram usadas na construção do projeto:

- C#
- JavaScript
- SQL Server
- CSS/HTML
- VS


---


### Dependências

|   Dependência      | Versão |
| -------------------| ------ |     
| Enity Frameworkcore| >= 8   |
| Xunit              |        |


### Autor do Projeto
Leinane Santos da Conceição  


