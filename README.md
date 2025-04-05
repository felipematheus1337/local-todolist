# 📝 ToDo List - Aplicação Console em C#

![C#](https://img.shields.io/badge/C%23-%23239120.svg?logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-5C2D91?logo=.net&logoColor=white)

## 📌 Funcionalidades Principais

### 👤 Gerenciamento de Usuários
- Criação de usuário com nome
- Geração automática de ID
- Armazenamento de tarefas por usuário

### ✅ Operações com Tarefas
- **Adição** de 1 a 5 tarefas por vez
- **Visualização** completa das tarefas
- **Remoção** por ID
- **Persistência** em diferentes formatos:
  - 📝 Texto (TXT)
  - 🔄 JSON (para integração)

## 🏗️ Implementação Técnica

### 🧩 Conceitos de POO Aplicados
- **Encapsulamento**
  - Classes com modificadores de acesso adequados
  - Propriedades com getters/setters
- **Separação de Responsabilidades**
  - Classes dedicadas `User` e `Tarefa`
  - Lógica de negócios separada em `BusinessService`
- **Princípios SOLID**
  - Responsabilidade Única (cada classe com propósito claro)
  - Aberto/Fechado (aberto para extensão, fechado para modificação)

### 🛠️ Padrões de Projeto
- **Camada de Serviço**: `BusinessService` como fachada para operações
- **Injeção de Dependências**: (simplificada) via métodos estáticos

## 🏗️ Estrutura do Projeto

### 🧩 Classes Principais
```csharp
Program.cs          // Ponto de entrada
BusinessService.cs  // Regras de negócio
User.cs             // Modelo de usuário
Tarefa.cs           // Modelo de tarefa
