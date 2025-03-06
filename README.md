# 💼 Projeto de Cálculo de Aposentadoria

Este projeto é uma aplicação **Windows Forms** que calcula a elegibilidade para aposentadoria com base nas regras do **INSS (Instituto Nacional do Seguro Social)** do Brasil.

## 🖥️ Funcionalidades
✅ Tela de Login com validação de usuário e senha <br>
✅ Tela de cálculo de aposentadoria <br>
✅ Verifica se o usuário pode se aposentar por idade mínima <br>
✅ Verifica se o usuário pode se aposentar por tempo de contribuição <br>
✅ Exibe uma mensagem informando se o usuário pode se aposentar ou quanto tempo falta para a aposentadoria <br>

## 📌 Regras de Aposentadoria (Baseadas no INSS)
🔹 **Homens:**
  - Aposentadoria por idade: **65 anos** e pelo menos **20 anos** de contribuição
  - Aposentadoria por tempo de serviço: **35 anos** de contribuição

🔹 **Mulheres:**
  - Aposentadoria por idade: **62 anos** e pelo menos **15 anos** de contribuição
  - Aposentadoria por tempo de serviço: **30 anos** de contribuição

## 🚀 Como Executar o Projeto
1. **Clone ou baixe o repositório**
2. **Abra o projeto no Visual Studio 2022**
3. **Certifique-se de ter o .NET 8 instalado**
4. **Compile e execute (`F5`)**
5. **Faça login com:**
   - Usuário: `rm98582@fiap.com.br`
   - Senha: `98582`
6. **Preencha os campos de idade, data de ingresso e data atual**
7. **Selecione o sexo**
8. **Clique no botão "Calcular" para verificar a elegibilidade para aposentadoria**

## 📂 Estrutura do Projeto
- `FormAposentadoria.cs`: Contém a lógica principal para calcular a elegibilidade para aposentadoria.
- `FormAposentadoria.Designer.cs`: Contém o código gerado automaticamente pelo designer do Windows Forms.
- `Program.cs`: Ponto de entrada da aplicação.

## 🛠️ Tecnologias Utilizadas
- **C# Windows Forms**
- **.NET 8**
- **Visual Studio 2022**

## 📜 Licença
Este projeto está licenciado sob a licença **MIT**. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.
