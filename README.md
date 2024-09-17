# Viagem-ao-desconhecido
Projeto voltado para o foco da escola Etec Basilides de Godoy chamado São Paulo 470 anos.

por: Isaque Dias, Kauan de Carlo Merida, Matheus Henrique e Pedro Santos

IDEIA

A ideia do nosso jogo foi concebida com a musica O Trem das Onzes e Samba Midnight, sendo por causa do contexto da musica O Trem das Onzes e o evento principal do Samba Midnight.

![image](https://github.com/user-attachments/assets/665e4b37-cf8b-4e63-bb22-e6ca4b3466f3)

![image](https://github.com/user-attachments/assets/ee19c53b-0a00-4edf-bbc7-741cdec630e2)

OBJETIVO

o intuito do nosso projeto é demonstrar como um trabalho obsessivo pode consumir a vida de uma pessoa na cidade de São Paulo, conscientizando sobre o desgaste emocional e físico que muitos trabalhadores sofrem, principalmente em cidades urbanas grandes como São Paulo.

HISTÓRIA

Adoniran Barbosa é um assistente de loja que está muito cansado e muito atrasado para voltar para casa e ver sua família, era 11 horas da noite na estação da luz e ele tinha que pegar um trem para consegui voltar para casa. Mas o trem possuía um ar macabro, uma aparência antiquada, recebendo assim vários boatos, superstições e mitos. Porém, Adoniran não iria acreditar em mitos sem fundamentos, ele era um homem sério, profissional e pai de família, não teria o motivo de temer um velho trem e se atrasar para ver seus filhos, então ele entra no trem estranho.

Quando Adoniran entra no trem, ele percebe que está completamente vazio, então no caminho de espera Adoniran acaba caindo no sono. Quando ele acorda percebe que o trem mudou de aparência, agora com uma aparência nada amigável, com buracos no chão além de objetos espalhados no trem. O homem vê monstros à sua frente, criaturas com uma aparência cadavérica e roupas rasgadas e mofadas. 

Quando ele passa pelo interminável vagão cheio de criaturas ele se vê em uma sala escura e algumas criaturas em sua frente, um deles olha fixamente para adorinan e diz: -Isso Tudo foi um sonho de um passo a frente e acorde. 

Adorinan dá o passo, mas o monstro o pega deixando o destino de Adorinan incerto.

ELEMENTOS

Nos elementos do menu utilizamos elementos de UI nos botões e o menu, usamos imagens de png para o fundo e a imagem que representa o som, baixamos sons mp3 como musica, além de programar a transição de cor do fundo dos botões de branco para vermelho.

![image](https://github.com/user-attachments/assets/446e2e60-fc81-4be0-8656-912dc8c460df)

![image](https://github.com/user-attachments/assets/56bf0155-c9d3-4adb-883f-946b377a81bd)

Nos elementos do Unity nós temos sete planos, para o chão, teto, paredes e portas. Colocamos um Material com uma imagem de um trem para a parede maior e um material cor cinza com aspecto metálico para o chão e o teto. Os dois planos menores foram para usados para ficar ao redor da porta como paredes, usamos um Material diferente com um cinza claro sem tanto o toque metálico. E dois planos ainda menores para ser as portas, usamos um Material com uma imagem de porta de trem para ambas as portas.

![image](https://github.com/user-attachments/assets/295c44da-c51c-40de-ac97-91b4ee0c0458)

Para os obstáculos e as lâmpadas foram usados objetos 3d do unity como cubos e cilindros, usamos uma imagem para criar o material usado para os obstáculos, e usamos o componente Light para poder colocar luzes nos objetos, entregando a ideia de ser lâmpadas ou objetos sobrenaturais.

Imagem dos obstáculos:

![image](https://github.com/user-attachments/assets/0a276702-7f23-43be-8014-2375fb84f4cd)

![image](https://github.com/user-attachments/assets/88a4c749-9c68-4605-ba11-9751a74e9ec4)

Para os personagens usamos modelos grátis da loja do Unity, para o Adoniran usamos o modelo do “FREE low poly man – RPG Character” e para os monstros usamos o modelo “Skeleton Ghost (FREE)”. Também usamos Physic Material e RigidBody em ambos os personagens, para que eles possuíssem colisão e tivessem gravidade. E por fim usamos Script C# para poder programar a movimentação de Adoniran, para os corvos usamos os modelos "Living Birds(FREE)", tbm usamos para todos os personagens Scripts C# para criar a movimentação deles e que caso algum obstáculo enconste em Adoniran ele volte para o inicio do vagão.

![image](https://github.com/user-attachments/assets/949a09fa-8d25-4151-b17f-52a168399003)

![image](https://github.com/user-attachments/assets/497b0086-05e6-4129-8810-76501d9c46b1)

![image](https://github.com/user-attachments/assets/cdc90b13-f3d9-4b6e-8697-3c30f077f128)

PALETA DE CORES

As cores principais do Adoniran, dos monstros e do trem será azul, cinza, preto e tons de vermelho.
Azul escuro representa o profissionalismo do personagem por ter ficado até tarde em seu trabalho porque precisaram de sua ajuda e por querer sustentar sua família, os zumbis usam o Azul para representar o profissionalismo do homem vindo o atormentar. Cinza é usado para a representação da neutralidade que o trem aparenta ter. O preto representa o Mal-estar que o personagem está sentido dentro dele Vermelho representa o perigo que os monstros representam para ele que são inimigos internos dele o atormentando. Temos os exemplos de cores:

![azul escuro](https://github.com/user-attachments/assets/6748480e-eebb-4144-ada3-33d6ba18b121)

cor: azul escuro

código hex:

#2A243A

![cinza claro](https://github.com/user-attachments/assets/422bc3a9-5612-4571-9d5d-b8f719dd9575)

cor: cinza claro

código hex:

#909090

![cinza](https://github.com/user-attachments/assets/e068bd47-b24e-45cb-a6ee-d3bc42f17565)

cor: cinza

código hex:

#686C73

![marrom](https://github.com/user-attachments/assets/5c669ea0-c825-4346-acbe-29cc4976370d)

cor: marrom

código hex:

#845E3D

![preto](https://github.com/user-attachments/assets/a3a9d221-6e7f-4b53-974a-24c0e8da37e9)

cor: Preta

código hex:

#000000

![vermelho](https://github.com/user-attachments/assets/fbca5cf1-8197-4329-9422-885e7791cbfa)

cor: vermelho

código hex:

#FF113D

LINKS DE REFERENCIAS E ASSETS STORE

[modelo Skeleton Ghost (FREE)](https://assetstore.unity.com/packages/3d/characters/creatures/skeleton-ghost-free-226070)

[modelo FREE low poly man – RPG Character](https://assetstore.unity.com/packages/3d/characters/humanoids/fantasy/free-low-poly-human-rpg-character-219979)

[modelo 3d dos corvos](https://assetstore.unity.com/packages/3d/characters/animals/birds/living-birds-15649)
