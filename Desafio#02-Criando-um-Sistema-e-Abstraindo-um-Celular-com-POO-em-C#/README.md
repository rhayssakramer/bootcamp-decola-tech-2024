## 📱 Sistema de Celulares em .NET - Programação Orientada a Objetos

Este repositório corresponde ao Desafio #02 da [Bootcamp Decola Tech 2024](https://web.dio.me/track/decola-tech-avanade-net-developer) para aplicar conhecimentos de **Programação Orientada a Objetos em** `C#`.
O objetivo é criar um sistema de console em .NET 6.0 que modele diferentes tipos de celulares, utilizando herança, abstração e polimorfismo.

## 📑 Índice
- [Introdução]()
- [Tecnologias Utilizadas]()
- [Desafio de Projeto]()
- [Objetivos]()
  - [x] [Pré-requisitos]()
  - [x] [Passo a Passo]()
  - [x] [Estrutura do Projeto]()
  - [x] [Regras e Validações]()
  - [x] [Especificações de Conteúdo]()
  - [x] [Especificações Técnicas]()
- [Modelo do Diagrama]()
- [Execução do Projeto]()
- [Créditos]()
- [Autora]()

### ▶️ Introdução
O desafio consiste em criar um sistema de console utilizando .NET e C# para treinar os conhecimentos adquiridos no módulo de `POO`. Na proposta do desafio o desenvoledor é responsável por modelar um sistema que trabalha com celulares que represente um modelo abstrato de celular, com comportamentos específicos para Nokia e iPhone. Para isso, foi preciso fazer o modelo abstrato de celular, que disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

### 💻 Tecnologias Utilizadas

| Linguagens de Programação | Ferramentas e Tecnologias |
| :-----------------: | :-----------------------: |
| <img height="40" src="https://skillicons.dev/icons?i=cs"> <img height="40" src="https://skillicons.dev/icons?i=dotnet"> <img height="40" src="https://skillicons.dev/icons?i=nodejs"> | <img height="40" src="https://skillicons.dev/icons?i=vscode">

### 🎯 Desafio de Projeto
- Criar uma classe abstrata `Smartphone` com atributos e métodos básicos.
- Criar duas classes filhas (`Nokia` e `Iphone`) que herdam da classe base.
- Implementar métodos sobrescritos para instalação de aplicativos, respeitando as diferenças de cada marca.

### 🛠️ Objetivos
O objetivo é aplicar os conceitos de POO aprendidos no módulo:
- Abstração
- Herança
- Polimorfismo
- Encapsulamento

#### 📌 Pré-requisitos
1. Ter o [.NET 6.0](https://dotnet.microsoft.com/pt-br/download/dotnet/6.0) instalado.
2. Ter o [Node.js](https://www.nodejs.tech/pt-br/download) instalado.
3. Editor de código [Visual Studio](https://visualstudio.microsoft.com/pt-br/) ou [VS Code](https://code.visualstudio.com/).

#### 🚀 Passo a Passo
1. Criar classe abstrata `Smartphone`.
2. Implementar métodos básicos (`Ligar`, `ReceberLigacao`).
3. Criar classes `Nokia` e `Iphone` herdando de `Smartphone`.
4. Implementar `InstalarAplicativo()` para cada modelo.
5. Testar as classes no `Program.cs`.  

#### 📂 Estrutura do Projeto**
```
SistemaCelulares/
│
├── 📁 Models
│   ├── Smartphone.cs
│   ├── Nokia.cs
│   └── Iphone.cs
│
├── 📁 Diagrams
│   └── diagrama-sistema-celulares.png
│
├── 📄 Program.cs
├── 📄 SistemaCelulares.csproj
└── 📄 README.md
```  

#### 📜 Regras e Validações
1. `Smartphone` deve ser **abstrata** e não pode ser instanciada servindo apenas como modelo.
```
Smartphone: `numero`  (string), `modelo`  (string), `imei` (string) e `memoria` (int). Sendo modelo, IMEI e memoria `privadas` e numero `pública`
```
2. `Nokia` e `Iphone` devem herdar de `Smartphone`.
```
Iphone: numero, modelo, imei e memoria com herança da classe smartphone.
Nokia: numero, modelo, imei e memoria com herança da classe smartphone.
```
3. O método `InstalarAplicativo` deve ser sobrescrito nas classes filhas, pois ambos possuem diferentes maneiras de instalar um aplicativo.    

#### 📂 Especificações de Conteúdo
- **Classe abstrata:** `Smartphone`
- **Propriedades:** 
  - `numero` (pública)
  - `modelo`, `imei`, `memoria` (privadas)
- **Métodos:**
  - `Ligar`()
  - `ReceberLigacao`()
  - `InstalarAplicativo()` (abstract)
```
Smarthpone: `Ligar()`, `ReceberLigacao()` e `IntalarAplicativos` (abstract).
Iphone: `InstalarAplicativos` (string nome) com herança da classe Smartphone.
Nokia: `InstalarAplicativos` (string nome) com herança da classe Smartphone.
 ```  

#### ⚙️ Especificações Técnicas
- Mensagens apropriadas devem ser exibidas em cada ação.
- Todos os dados são capturados pelo sistema.
- Uso de propriedades públicas e privadas.
- Implementar todo o código marcado com `// TODO`.  

### 📊 Modelo do Diagrama
```
Criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone.
```
<img width="400" align="center" src="./images/diagrama.png">

### ⏩ Execução do Projeto
1. Clone este repositório.
2. No terminal, navegue até o diretório do projeto.
3. Execute:
```
dotnet run
```
## 🗒️ Recursos Adicionais
- [Documentação de C#](https://learn.microsoft.com/pt-br/dotnet/csharp/)
- [Documentação de .NET](https://learn.microsoft.com/pt-br/dotnet/)
- [C# - Linguagem de Programação](https://dotnet.microsoft.com/pt-br/languages/csharp)

## 🔗 Créditos
Este projeto foi desenvolvido como parte de avaliação de Desafio de Projeto do Decola Tech Avanade 2024, para avaliar o ensinado na bootcamp de POO da linguagem de programação `C#`.

*Nota: Este projeto é apenas para fins educacionais e não possui nenhuma afiliação oficial com a franquia DIO ou Avanade ou suas empresas associadas.*

## 👩🏼‍💻 Autora:
<table style="border=0">
  <tr>
    <td align="left">
      <a href="https://github.com/rhayssakramer">
        <span><b>Rhayssa Kramer</b></span>
      </a>
      <br>
      <span>Assoc, Full-Stack Development</span>
    </td>
  </tr>
</table>

<div align="center"><a href="https://github.com/rhayssakramer"><img src="https://github.com/rhayssakramer/rhayssakramer/blob/main/img/rodape.png"></a></div>
