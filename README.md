# CRM Console Application

[![C#](https://img.shields.io/badge/C%23-Visual_Studio-blue)](https://dotnet.microsoft.com/)
[![.NET](https://img.shields.io/badge/.NET-6%2F7%2F8-blue)](https://dotnet.microsoft.com/)

Este é um **CRM (Customer Relationship Management)** simples desenvolvido em **C#** como aplicação de console.  
O projeto permite gerenciar clientes de forma básica, oferecendo funcionalidades de **CRUD (Criar, Ler, Atualizar e Excluir)** através de um menu interativo no console.

---

## 🏗 Estrutura do Projeto

- **Cliente**: representa um cliente com informações básicas.
```csharp
public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
}
````

- Produto (opcional): caso deseje gerenciar produtos ou serviços.
- Venda (opcional): para registrar vendas vinculadas a clientes.

## Listas em memória

Os dados dos clientes são armazenados temporariamente usando:

List<Cliente> clientes = new List<Cliente>();

## ⚙ Funcionalidades
**CRUD**

Cadastrar cliente: solicita os dados do usuário pelo console e adiciona à lista.

Listar clientes: exibe todos os clientes cadastrados com seus detalhes.

Atualizar cliente: permite alterar nome, email ou telefone de um cliente pelo seu ID.

Excluir cliente: remove um cliente da lista pelo seu ID.

## 📋 Menu de Exemplo
```csharp
Console.WriteLine("1. Cadastrar cliente");
Console.WriteLine("2. Listar clientes");
Console.WriteLine("3. Atualizar cliente");
Console.WriteLine("4. Excluir cliente");
Console.WriteLine("0. Sair");
````

## 💻 Tecnologias

C# 10+

.NET 9 (Console Application)

## 🎯 Objetivo

Este projeto serve para:

Aprender conceitos de orientação a objetos.

Manipular listas em memória.

Construir aplicações de console simples.

Gerenciar clientes de forma prática e didática.
