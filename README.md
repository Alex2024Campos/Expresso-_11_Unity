# Expresso_11
>[!Important]
` - Projeto:`
>- Turma: 2°Mtec Desenvolvimento de Jogos Digitais.
>- Escola: Etec Prof. Basilides de Godoy.
>- Sobre: Repositório para a documentação do jogo Expresso 11, desenvolvido para a feira cultural da Etec Prof. Basilides de Godoy.
>- Datas: Gravar as fases (Quinta), entregar a documentação (Quinta), apresentação do jogo (Quinta).
>- Projeto (drive): https://drive.google.com/drive/u/0/folders/11AYAafGOKnD0kKMby2S_ybv2LrDbRA2h

>[!Important]
> ` - Equipe:`
>- Alex Campos de Oliveira
>- Christian Varandas
>- Guilherme Henrique
>- Igor Michelini

> [!NOTE]
> `- Alterações do Jogo:`
>- Script CriarCena (retirado): O CriarCena foi retirado devido a sua complexidade (na questão da codificação) e a falta de harmonia com outros scripts, logo, foi de preferência da nossa equipe montar as cenas a mão.
>- Cena "Esgoto"  (retirado): Pela falta de tempo para desenvolver, arrumar e testar a cena Esgoto, a mesma foi retirada adjunto de seus inimigos (lizardman, um tipo de humano-reptil, e o rato).
>- Ataque "Voadora"  (retirado): Devido aos problemas para fazer a animação funcionar e a criação de uma colisão para eliminar os inimigos ao ser utilizada, a voadora foi retirada do jogo.
>- Timer (alterado): Anteriormente, era planejado para o timer se de 10 minutos e ter a mecânica de ser constante em ambas as cenas, ou seja, o timer final da cena "Rua" seria levado para a cena "Estação", mas devido a dificuldade para fazer isso e também pela decisão de retirar o script CriarCena, optamos por diminuir o timer para x minuitos (!!!!colocar o timer) na "Rua" e x minutos (!!!!!!colocartambém) na "Estação".

> [!TIP]
>- Gameplay:
https://github.com/user-attachments/assets/8844c4da-32dd-43eb-bdd7-10f0b96e27ac

_________________________________________________________________________________________________________________________________ 



# História do Game:
-  Juninho da Silva Cleidson é alguém de origem humilde que mora com sua esposa, Alexandria, no Bairro Bom Retiro. Enquanto sua esposa, atualmente desempregada, está focada nas tarefas de casa, Juninho depende de seu emprego para pagar as despesas e trazer a comida. Outros personagens são os NPCs nas ruas, que serão obstáculos do protagonista. Estes, estão fazendo suas atividades diversas do dia a dia, mas infelizmente seu destino fica na direção oposta do de Juninho. 
 Certo dia, enquanto estava afundado em suas fantasias do sono, Juninho é acordado pelo temível som de seu despertador – “Já são 10:45”, a fatídica voz robótica do alarme se mostrou o suficiente para fazê-lo levantar em desespero, preparar as suas coisas às pressas e se retirar de casa com sua mochila, não conseguindo nem mesmo se despedir de Alexandria, pois a pontualidade em seu emprego é rígida. 
 Ele então parte de sua morada na direção da estação mais próxima na tentativa de chegar a tempo.
_________________________________________________________________________________________________________________________________ 
# Animações:
- As animações foram planejadas e organizadas com base em dois vídeos do Youtube (https://youtu.be/cndsQp-Yuzw?si=o3vLwQLL8izTha3g e https://youtu.be/ugqhZBJpH9w?si=zt8iy4wPhLOBkDRq). Os modelos e animações, entretanto, foram pegos da Mixamo e extraídos para o Unity, aonde tiveram suas texturas carregadas e os tipos separados por pastas (animações, personagens e controllers). Para cada personagem e NPC, foi-se feito um controller para fazer o carregamento da animação sem nenhum problema, pois cada uma deveria ser carregada com o modelo que fosse ser utilizado na Mixamo. Com os controller criados, só foi necessário puxar as animações para dentro do painel e deixa-las como default em cada um. Vale ressaltar que, após baixadas as animações com os modelos de cada personagem, as mesmas foram retiradas com ctrl + D da pasta que já vinham e essa pasta, apagada.
_________________________________________________________________________________________________________________________________ 

# Colisões:
- As colisões de nosso jogo foram utilizadas, principalmente, para a criação do contato, diminuição do "timer" do personagem principal e para a destruição dos Npcs que colidissem (os inimigos do jogo), mas também utilizamos delas para fazer a troca de cenas e trazer o aumento do som da música do jogo. A príncipio, foram-se feitos objetos vazios e só após isso, adicionadas as colisões (box collider) nesses objetos vazios (houve a necessidade de alterar as caixas de colisões deles), vale também ressaltar que essa tátitca foi utilizada somente para: a ação de trocar de cena e o aumento do som. Agora, para os Npcs do jogo foi somente adicionado um Box Collider nos modelos pré-separados para fazer a identificação da colisão e, no caso da destruição dos inimigos (que são clonados para a repetição dos mesmos), foi-se feito um código para deleta-los após ultrapassarem determinada distância no eixo X.
_________________________________________________________________________________________________________________________________ 



# Scripts:
- Os scripts criados para o jogo foram:
- 
  1 - MenuPausa
  
  2 - GameOver
  
  3 - CriaCena
  
  4 - Spawn
  
  5 - Colisao
  
  6 - cronometro
  
  7 - Jogar
  
  8 - Sobre
  
  9 - TrocarCena
  
  10 - MovCam
  
  11 - MovNPC
  
  12 - MovPers
  
  13 - perfis
  
  14 - ScriptCutsceneFinal
  
  15 - ScriptFinal
  
  16 - voltae

 ## - Cenario (Pasta)
 
 -> Colisao: É a colisão colocada nos Npcs para identificar quando houver contato com um gameobject de nome "player", caso ocorra esse contato, o objeto é destruido e o tempo do cronometro é subtraido por 10 (diminue 10 segundos).
  <br>
  
 -> Spawn: O Spawn é colocado em um objeto vazio, fazendo-o se mover em zig-zag para a direita e spawnar de forma randomica os modelos separados previamente (nesse caso, estão dentro de um objeto vazio chamado "Npcs"). Foi imposto um limite em que esse objeto vazio pode se locomover no eixo X, o parando quando se aproxima da estação e ainda sim mantendo o movimento de zig-zag e o spawn dos modelos.
 <br>
 
 ## - Jogo (Pasta)
 -> cronometro: É o script que tem os códigos para a criação do timer, a sua constante queda e também o que chama, no caso de o timer chegar a zero, o telaGameOver e desativa a música.
 <br>
 
 -> GameOver: Serve para que, quando o jogador perder o jogo e aparecer o menu de derrota (vulgo telaGameOver), seja possível que o mesmo aperte o botão de reiniciar e ai recomeçar o jogo (eu acho).
 <br>
 
 -> Jogar: Como o GameOver, acaba sendo útil para que quando pressionado o botão de iniciar, o jogo inicie na cena "Rua".
 <br>
 
 -> MenuPausa: É o código que ativa e desativa o menu de pausa do jogo
 <br>
 
 -> Sobre: O script que controla o aba Sobre Nós do menu principal 
 <br>
 
 -> Trocar_cena: Utilizando-se de um objeto vazio e um collider inserido nele, o script Trocar_cena identifica se houve alguma colisão com o collider do objeto vazio "TrocarCena" e se ocorrer, troca para a próxima cena que foi posta previamente no objeto dentro do unity (é uma string pública).
 <br>
 
 ## - Movimentação_Personagem (Pasta)
 <br>
 
 -> MovCam: É o código que tem a movimentação da câmera, a qual, segue o objeto selecionado que no caso do Expresso 11, é o "player".
 <br>
 
 -> MovNpc: É a movimentação dos Npcs (inimigos) que se movem somente no eixo X para a esquerda. Não tem nada a mais, é somente uma movimentação constante para a esquerda e que, após ultrapassar determinada posição, deleta o determinado objeto.
 <br>
 
 -> movPers: Tem a função de conter a movimentação do jogador, o qual pode ser mover para cima, baixo e pular (teclas, respectivamente: W, S, Space). Tem uma velocidade constante no eixo X, o qual aparece no eixo Z dentro do script devido a manipulação da rotação dos modelos da Mixamo (que é utilizado nos personagens e, como já é de se imaginar, no player também) que acabou por bugar um pouco os eixos.
_________________________________________________________________________________________________________________________________ 



# Cores
- Para o jogo, foram-se utilizadas de cores mais cinzas e escuras, com esse padrão sendo quebrado somente para alguns objetos com o objetivo de seguir, em partes, fielmente as cores de determinado objeto na vida real (como é o caso das máquinas de refrigerante na estação, cadeiras, dentre outros). Além do cinza, foi-se muito utilizado do branco e também do marrom mais escuro e claro, sempre fazendo uma troca entre esses dois.
_________________________________________________________________________________________________________________________________ 



# AssetStore e Criação de Cena:
- Alguns dos conjuntos de modelos 3D (ou em outras palavras, "Pacotes) abaixo não foram utilizados para a composição do cenário, sendo retirados devido a falta de outros modelos de texturas semelhantes para complementa-los, no entanto, connseguimos achar modelos de Polygon (modelos poligonais, meio quadrado) para ocupar essa espaço. Para a composição das cenas do jogo, os pacotes tiveram seus modelos separados em: "Organizado" e "Others", aonde um continha os modelos separados em tipo (móveis, veículos, etc) e outro para manter os "pacotes" originais, ou seja, as pastas de cada conjunto da AssetStore. Outros modelos pegos, nesse caso os dos personagens e as animações de corrida, vieram da Mixamo e colocados em uma pasta chamada de "Personagens" que continha outras sub-pastas que separavam animações, os obstáculos (Npcs), as animações e os controllers de cada modelo (esses controllers servem para controlar a questão das animações de cada modelo). Por fim, também foram feitas pastas para guardar e deixar melhor organizado as texturas e os materiais utilizados.

# UI
- Menu: O menu é uma cena separada, que carrega a cena "Rua" quando o jogador aperta no botão de jogar, utilizando do comando SceneManager.LoadSceneAsync("Rua"). Foram utilizados os componentes Text(TextMeshPro), Button e Panel. O menu Sobre Nós é um painel transparente (para manter o fundo do trem), que é apenas ativado ao clique do botão, utilizando o comando SetActive(True)
- Cronometro: O Cronometro é novamente feito com um Text - TextMeshPro, na aba do código é primeiro definido a quantidade de segundos para o jogo. Depois no método Update() é criada uma condiçãp: Se tempoRestate > 0, diminua o tempo por deltaTime, isso faz com que o cronometro diminua em um valor constante, independente do quão potente é o computador, caso contrário, ele mostra a tela de derrota. Logo após isso, são criadas duas variáveis locais: minutos e segundos, que recebem o valor de tempoRestante em segundos e formatam usando divisão e módulo para o valor desejado. Depois de utiliza o comando String.Format para formatar e mostrar o tempo restante de uma forma melhor
- Game Over: É um painel transparente, que é ativado a partir do script do cronômetro, quando o valor do tempoRestante chega a 0, é composto por um Text e um Button e um comando Time.timescale = 0.0f, para pausar o jogo completamenete. O botão tem o código SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name) que carrega a cena atual novamente
- Menu de Pausa: É um painel com três botões: Continuar, Voltar ao Menu e Voltar ao Desktop. Para pausar, é usado o comando Time.TimeScale = 0.0f, que deixa o jogo pausado, logo após, é carregado o menu de pausa com o SetActive(true). Para voltar ao menu, é utilizado o comando SceneManager.LoadSceneAsync("Menu"), para ir ao desktop, é utilizado o Application.Exit(), para continuar é apenas desativado o menu de pausa, e o valor do Time.timescale é colocado em 1, que é a velocidade padrão do jogo
- Final: Um painel preto, com os componentes Text e Button, com o Text descrevendo o que acontece no final e o botão contendo o código SceneManager.LoadSceneAsync("Menu"), para voltar ao menu.

## Referências:

https://assetstore.unity.com/packages/3d/props/shelves01-pack-289927

https://assetstore.unity.com/packages/3d/props/shelves01-pack-289927

https://assetstore.unity.com/packages/3d/props/simple-houses-pack-285349

https://assetstore.unity.com/packages/3d/props/simple-houses-pack-285349

https://assetstore.unity.com/packages/3d/environments/samhui-restaurant-282535

https://assetstore.unity.com/packages/3d/environments/samhui-restaurant-282535

 https://assetstore.unity.com/packages/3d/vehicles/land/korean-presidential-coach-279420

https://assetstore.unity.com/packages/3d/vehicles/land/korean-presidential-coach-279420

 https://assetstore.unity.com/packages/3d/environments/urban/low-polygon-house-277446
 
 https://assetstore.unity.com/packages/3d/environments/urban/low-polygon-house-277446

https://assetstore.unity.com/packages/3d/props/traffic-control-pack1-4919

https://assetstore.unity.com/packages/3d/props/traffic-control-pack1-4919

https://assetstore.unity.com/packages/3d/environments/urban/vrbn-studios-free-buildings-urp-bundle-001-264015

https://assetstore.unity.com/packages/3d/environments/urban/simple-cafe-258876

https://assetstore.unity.com/packages/3d/props/shelves01-pack-289927

https://assetstore.unity.com/packages/3d/props/shelves01-pack-289927

https://assetstore.unity.com/packages/3d/props/simple-houses-pack-285349

https://assetstore.unity.com/packages/3d/props/simple-houses-pack-285349

https://assetstore.unity.com/packages/3d/environments/samhui-restaurant-282535

https://assetstore.unity.com/packages/3d/environments/samhui-restaurant-282535

https://assetstore.unity.com/packages/3d/vehicles/land/korean-presidential-coach-279420

https://assetstore.unity.com/packages/3d/vehicles/land/korean-presidential-coach-279420

https://assetstore.unity.com/packages/3d/environments/urban/low-polygon-house-277446
 
https://assetstore.unity.com/packages/3d/environments/urban/low-polygon-house-277446
