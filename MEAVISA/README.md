# **MEAVISA** 📲

MEAVISA é um aplicativo móvel desenvolvido para conectar cidadãos e administrações municipais de forma eficiente e prática.

## **Sumário** 📗

1. [Descrição do Projeto 📃](#descrição-)
2. [Funcionalidades 🌟](#funcionalidades-)
3. [Benefícios 🌐](#benefícios-)
4. [Como Funciona 🚀](#como-funciona-)
5. [Público-Alvo 🎯](#público-alvo-)
6. [Requisitos ✅](#requisitos-)
   - [Requisitos Funcionais](#requisitos-funcionais)
   - [Requisitos Não Funcionais](#requisitos-não-funcionais)
7. [Implementação 🖥️](#implementação-)
8. [Como Contribuir 🤝](#como-contribuir-)


## **Descrição** 📃

O app permite que os moradores recebam notificações personalizadas baseadas em suas preferências, como categoria de interesse e localização, diretamente no WhatsApp ou por e-mail.

## **Funcionalidades** 🌟

### Cadastro de Preferências:

Escolha as categorias de notificação que deseja receber (ex.: saúde, eventos, segurança, entre outras).

Informe o bairro onde você mora para receber informações específicas da sua localidade.

### Escolha do Canal de Comunicação:

Receba notificações no seu WhatsApp ou e-mail, conforme sua preferência.
Envio Personalizado de Notificações:

A administração municipal envia avisos e alertas com base nas categorias e bairros cadastrados pelos usuários.

## **Benefícios** 🌐

- **Informação Localizada**: Receba apenas o que é relevante para você, evitando excesso de mensagens.

- **Canais Práticos**: Escolha como prefere ser avisado, garantindo que as informações cheguem no formato mais conveniente.

- **Conexão Direta com a Cidade**: Fique atualizado sobre serviços públicos, eventos e outras novidades importantes.

## **Como Funciona**? 🚀

### Cadastro Inicial:

#### Baixe o app MEAVISA.

Preencha seu nome, e-mail ou número do WhatsApp, e escolha suas preferências de notificação (categoria e bairro).
Recebimento de Notificações:

A administração municipal usa o sistema para enviar mensagens personalizadas diretamente para você.

#### Atualização de Preferências:

Caso suas preferências mudem, é fácil atualizar seus dados no app.

## **Público-Alvo** 🎯

- **Cidadãos**: Moradores que desejam estar sempre informados sobre questões relevantes de sua cidade.

- **Administração Municipal**: Gestores que querem melhorar a comunicação com a população de forma segmentada e eficiente.

## **Requisitos** ✅

- [PLANEJAMENTO](https://www.figma.com/design/9qhP5CRmJDDa96Bb3tBSoV/MEAVISA?node-id=0-1&t=VV4tqSrz878iZjC4-1)

:hammer:: Em progresso

:ballot_box_with_check:: Feito

### **Requisitos Funcionais**

| **Código** | **Título**     | **Descrição**                                                                                                       |
| :--------: | -------------- | --------------------------------------------------------------------------------------------------------------------|
|    RF01    | Cadastro de Usuários    | Permitir que moradores se cadastrem no sistema :hammer:                                                    |
|    RF02    | Cadastro de Notificação | Área administrativa para criar e enviar notificações :hammer:                                              |
|    RF03    | Envio de Notificações   | Para o administrador, possibilidade de enviar notificações com base nas preferências dos usuários :hammer: |
|    RF04    | Listagem de Posts       | Para o administrador, listagem de tudo o que foi enviado :hammer:                                          |

### **Requisitos Não Funcionais**

| **Código** | **Título**     | **Descrição**                                                                       |
| :--------: | -------------- | ----------------------------------------------------------------------------------- |
|   RNF01    | Usabilidade    | App deve ser fácil de navegar para usuários de todas as idades :hammer:             |
|   RNF02    | Desempenho     | Suporte a múltiplos usuários simultâneos :hammer:                                   |
|   RNF03    | Segurança      | Implementação de segurança para proteger os dados dos usuários :hammer:             |
|   RNF04    | Acessibilidade | Conformidade com diretrizes para garantir acesso a pessoas com deficiência :hammer: |

## **Implementação** 🖥️

| **Componente** | **Ferramenta Utilizada**                                      |
| -------------- | ------------------------------------------------------------- |
| Front-End      | .Net MAUI :hammer:                                            |
| Back-End       | C# (ASP.NET Core) :hammer:                                    |
| Banco de Dados | MongoDB :hammer:                                              |
| Cache          | Redis :hammer:                                                |
| Integração     | Serviço para envio de mensagens no WhatsApp e e-mail :hammer: |

## Como Contribuir 🤝

Este projeto é open-source e pode ser melhorado com a ajuda da comunidade! Para contribuir:

- Faça um fork do repositório.

- Crie uma branch para sua feature/bugfix: git checkout -b minha-feature.

- Envie um pull request com suas alterações.

MEAVISA: Mantendo você conectado e informado, onde quer que esteja. 💬
