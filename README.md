# Upload de Arquivo para Firebase com Tailwind CSS + Atividade Avaliativa de Realidade Virtual e Aumentada (RVA)

Este projeto fornece uma página web simples para upload de arquivos no Firebase Storage utilizando Tailwind CSS para estilização.

## Começando

Siga as instruções abaixo para configurar e usar este projeto.

### Pré-requisitos

Você precisa ter os seguintes itens instalados no seu sistema:

- Um navegador web (por exemplo, Chrome, Firefox)
- Uma conexão com a internet

### Configuração

1. Clone o repositório ou baixe os arquivos do projeto.

2. Abra o arquivo `index.html` em um editor de código de sua preferência.

3. Adicione os valores de configuração do seu Firebase na seção `<script>` no final do arquivo `index.html`. Substitua os valores de exemplo pelas configurações do seu projeto Firebase.

```html
<script>
  // Configuração do Firebase do seu aplicativo web
  const firebaseConfig = {
    apiKey: "SUA_API_KEY",
    authDomain: "SEU_AUTH_DOMAIN",
    projectId: "SEU_PROJECT_ID",
    storageBucket: "SEU_STORAGE_BUCKET",
    messagingSenderId: "SEU_MESSAGING_SENDER_ID",
    appId: "SEU_APP_ID"
  };

  // Inicializar Firebase
  firebase.initializeApp(firebaseConfig);
  const storage = firebase.storage();
</script>


```
4. Após o upload ser concluído, a URL do arquivo enviado será exibida. Como o arquivo sempre terá o nome `video.mp4`, a URL gerada será a mesma para todos os uploads.

### Uso

1. Abra o arquivo index.html em um navegador web.
2. Selecione um arquivo para upload clicando no botão "Escolher arquivo".
3. Clique no botão "Upload" para fazer o upload do arquivo selecionado para o Firebase Storage.
4. Após o upload ser concluído, a URL do arquivo enviado será exibida.

### Utilizando a URL do Arquivo no Unity

 - Após fazer o upload do arquivo para o Firebase, você receberá uma URL pública que pode ser usada para acessar o arquivo. Como o arquivo sempre terá o nome video.mp4, a URL gerada será a mesma para todos os uploads. 


### Dependências
Este projeto utiliza as seguintes dependências:

- Tailwind CSS: Um framework CSS utilitário.
- Firebase: Uma plataforma desenvolvida pelo Google para a criação de aplicativos móveis e web.
