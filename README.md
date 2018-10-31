# Entendendo MVC
### Modelo-Visão-Controle

* É modelo de desenvolvimento que divide o desenvolvimento do aplicativo em 3 camadas (modelo, controle, visão), onde cada camada fica responsável, por uma parte especifica do projeto.

![alt tag](https://raw.githubusercontent.com/NathanaelDelfino/EntendendoMVC/master/imagens/mvc.png)

## Modelo
* Camada responsável por armazenar os dados.
* Responsável pela leitura, manipulação e validação do dados.
* Responsável por tratar as regras de negócio.
...

## Visão
* Camada que exibe uma representação do dados.
* É a camada de interface com o usuário (View). (Também conhecida como client-side)
...

## Controle
* Exerce controle de qual modelo será aplicado e qual view exibida ao usuário.
* Tem acesso as camadas modelo e visão.
* Recebe as requisições feitas pelo usuário e traduz em comandos que são enviados para a camada modelo ou para visão. 
...


## Fontes
[Wikipedia](https://pt.wikipedia.org/wiki/MVC) - MVC

[Portal TSI](https://www.portalgsti.com.br/2017/08/padrao-mvc-arquitetura-model-view-controller.html) - Padrão MVC | Arquitetura Model-View-Controller 

[Macoratti](http://www.macoratti.net/vbn_mvc.htm) - Padrões de Projeto : O modelo MVC - Model View  Controller