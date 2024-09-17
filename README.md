# Expresso_11
>[!Important]
>- Turma: 2°Mtec Desenvolvimento de Jogos Digitais.
>- Escola: Etec Prof. Basilides de Godoy.
>- Sobre: Repositório para a documentação do jogo Expresso 11, desenvolvido para a feira cultural da Etec Prof. Basilides de Godoy.
>- Datas: Gravar as fases (Quinta), entregar a documentação (Quinta), apresentação do jogo (Quinta).
>- Projeto (drive): https://drive.google.com/drive/u/0/folders/11AYAafGOKnD0kKMby2S_ybv2LrDbRA2h{




## Nomes:
-> Alex Campos de Oliveira
<br>
-> Christian Varandas
<br>
-> Guilherme Henrique
<br>
-> Igor Michelini



# História do Game:
-  Juninho da Silva Cleidson é alguém de origem humilde que mora com sua esposa, Alexandria, no Bairro Bom Retiro. Enquanto sua esposa, atualmente desempregada, está focada nas tarefas de casa, Juninho depende de seu emprego para pagar as despesas e trazer a comida. Outros personagens são os NPCs nas ruas, que serão obstáculos do protagonista. Estes, estão fazendo suas atividades diversas do dia a dia, mas infelizmente seu destino fica na direção oposta do de Juninho. 
 Certo dia, enquanto estava afundado em suas fantasias do sono, Juninho é acordado pelo temível som de seu despertador – “Já são 10:45”, a fatídica voz robótica do alarme se mostrou o suficiente para fazê-lo levantar em desespero, preparar as suas coisas às pressas e se retirar de casa com sua mochila, não conseguindo nem mesmo se despedir de Alexandria, pois a pontualidade em seu emprego é rígida. 
 Ele então parte de sua morada na direção da estação mais próxima na tentativa de chegar a tempo.



# Colisões:
- As colisões de nosso jogo foram utilizadas, principalmente, para a criação do contato, diminuição do "timer" do personagem principal e para a destruição dos Npcs que colidissem (os inimigos do jogo), mas também utilizamos delas para fazer a troca de cenas e trazer o aumento do som da música do jogo. A príncipio, foram-se feitos objetos vazios e só após isso, adicionadas as colisões (box collider) nesses objetos vazios (houve a necessidade de alterar as caixas de colisões deles), vale também ressaltar que essa tátitca foi utilizada somente para: a ação de trocar de cena e o aumento do som. Agora, para os Npcs do jogo foi somente adicionado um Box Collider nos modelos pré-separados para fazer a identificação da colisão e, no caso da destruição dos inimigos (que são clonados para a repetição dos mesmos), foi-se feito um código para deleta-los após ultrapassarem determinada distância no eixo X.

# Scripts:
- Os scripts criados para o jogo foram:

 ## - Cenario (Pasta)
 
 -> Colisao: É a colisão colocada nos Npcs para identificar quando houver contato com um gameobject de nome "player", caso ocorra esse contato, o objeto é destruido e o tempo do cronometro é subtraido por 10 (diminue 10 segundos).
<br>

 -> CriarCena:
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
 
 -> MenuPausa:
 <br>
 
 -> Sobre:
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

# Cores
- Para o jogo, foram-se utilizadas de cores mais cinzas e escuras, com esse padrão sendo quebrado somente para alguns objetos com o objetivo de seguir, em partes, fielmente as cores de determinado objeto na vida real (como é o caso das máquinas de refrigerante na estação, cadeiras, dentre outros). Além do cinza, foi-se muito utilizado do branco e também do marrom mais escuro e claro, sempre fazendo uma troca entre esses dois.

# AssetStore e Criação de Cena:
- Alguns dos conjuntos de modelos 3D (ou em outras palavras, "Pacotes) abaixo não foram utilizados para a composição do cenário, sendo retirados devido a falta de outros modelos de texturas semelhantes para complementa-los, no entanto, connseguimos achar modelos de Polygon (modelos poligonais, meio quadrado) para ocupar essa espaço. Para a composição das cenas do jogo, os pacotes tiveram seus modelos separados em: "Organizado" e "Others", aonde um continha os modelos separados em tipo (móveis, veículos, etc) e outro para manter os "pacotes" originais, ou seja, as pastas de cada conjunto da AssetStore. Outros modelos pegos, nesse caso os dos personagens e as animações de corrida, vieram da Mixamo e colocados em uma pasta chamada de "Personagens" que continha outras sub-pastas que separavam animações, os obstáculos (Npcs), as animações e os controllers de cada modelo (esses controllers servem para controlar a questão das animações de cada modelo). Por fim, também foram feitas pastas para guardar e deixar melhor organizado as texturas e os materiais utilizados.

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
