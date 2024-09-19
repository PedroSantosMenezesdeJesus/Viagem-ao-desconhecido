# Viagem-ao-desconhecido
Projeto voltado para o foco da escola Etec Basilides de Godoy chamado São Paulo 470 anos.

Por: Isaque Dias, Kauan de Carlo Merida, Matheus Henrique e Pedro Santos

IDEIA

A ideia do nosso jogo foi concebida com a música O Trem das Onzes e Samba Midnight, sendo por causa do contexto da música O Trem das Onzes e o evento principal do Samba Midnight.

![trem das onze](https://github.com/user-attachments/assets/665e4b37-cf8b-4e63-bb22-e6ca4b3466f3)

![sampa midnight](https://github.com/user-attachments/assets/ee19c53b-0a00-4edf-bbc7-741cdec630e2)

OBJETIVO

O intuito do nosso projeto é demonstrar como um trabalho obsessivo pode consumir a vida de uma pessoa na cidade de São Paulo, conscientizando sobre o desgaste emocional e físico que muitos trabalhadores sofrem, principalmente em cidades urbanas grandes como São Paulo.

HISTÓRIA

Adoniran Barbosa é um assistente de loja que está muito cansado e muito atrasado para voltar para casa e ver sua família, era 11 horas da noite na estação da luz e ele tinha que pegar um trem para consegui voltar para casa. Mas o trem possuía um ar macabro, uma aparência antiquada, recebendo assim vários boatos, superstições e mitos. Porém, Adoniran não iria acreditar em mitos sem fundamentos, ele era um homem sério, profissional e pai de família, não teria o motivo de temer um velho trem e se atrasar para ver seus filhos, então ele entra no trem estranho.

Quando Adoniran entra no trem, ele percebe que está completamente vazio, então no caminho de espera Adoniran vai ao outro vagão para dormir. Quando ele atravessa a porta ele percebe que o trem mudou de aparência, agora com uma aparência nada amigável, com buracos no chão além de objetos espalhados no trem. O homem vê monstros à sua frente, criaturas com uma aparência cadavérica e roupas rasgadas e mofadas.

Quando ele passa pelo interminável vagão cheio de criaturas ele se vê em uma sala escura e algumas criaturas em sua frente, um deles olha fixamente para Adorinan e diz: -Isso tudo foi um sonho, nada é real. Dê um passo a frente.

Adorinan dá o passo, mas o monstro o capturou deixando o destino de Adorinan incerto.

ELEMENTOS

No menu utilizamos elementos UI nos botões e textos, usamos imagens para o fundo e icone de volume para habilitar o som, baixamos audios para elementos do jogo como passos ou trilha sonora, além de programar a transição de cor do fundo dos botões de branco para vermelho.

![materiais menu](https://github.com/user-attachments/assets/5d1efd0d-d2d3-4047-845e-3a7cd3f0b011)

![menu](https://github.com/user-attachments/assets/56bf0155-c9d3-4adb-883f-946b377a81bd)

Dos elementos do Unity foram usados planos, para o chão, teto, paredes e portas. Criamos um Material com uma imagem de um trem para o cenário e diversos materiais com aspecto metálico, no teto usamos uma imagem de um material metálico. Os dois planos menores foram para usados para ficar ao redor da porta como paredes, usamos um Material diferente com um cinza metálico e dois planos ainda menores para ser as portas, usamos um Material com uma imagem de porta de trem para ambas as portas.

![elementos](https://github.com/user-attachments/assets/6a134bcf-a03f-468d-908a-f45a236adff5)

Para os obstáculos e as lâmpadas foram usados objetos 3d do unity como cubos e cilindros, usamos uma imagem para criar o material usado para os obstáculos, e usamos o componente Light para poder colocar luzes nos objetos, entregando a ideia de ser lâmpadas ou objetos sobrenaturais. Para os buracos foram utilizados o material completamente preto dando a impressão de um vazio.

Imagem dos obstáculos:

![image](https://github.com/user-attachments/assets/0a276702-7f23-43be-8014-2375fb84f4cd)

![image](https://github.com/user-attachments/assets/d1ef32d1-db81-43a6-b064-43fb85a2baaa)

Para os personagens usamos modelos grátis da loja do Unity, para o Adoniran usamos o modelo do “FREE low poly man – RPG Character” e para os monstros usamos o modelo “Skeleton Ghost (FREE)”. Também usamos Physic Material e RigidBody em ambos os personagens, para que eles possuíssem colisão e tivessem gravidade. E por fim usamos Script C# para poder programar a movimentação de Adoniran, para os corvos usamos os modelos "Living Birds(FREE)", tbm usamos para todos os personagens Scripts C# para criar a movimentação deles e que caso algum obstáculo enconste em Adoniran ele volte para o início do vagão.

![image](https://github.com/user-attachments/assets/949a09fa-8d25-4151-b17f-52a168399003)

![image](https://github.com/user-attachments/assets/497b0086-05e6-4129-8810-76501d9c46b1)

![image](https://github.com/user-attachments/assets/cdc90b13-f3d9-4b6e-8697-3c30f077f128)

A música e os efeitos sonoros do passo e do grito foram arquivos mp3, baixamos a música no Mp3Convetor e os sons no assest store Footsteps - Essentials, usamos "audioSorce.play()" para tocar os audíos.

![Footsteps](https://github.com/user-attachments/assets/84350566-dfde-4802-a7a5-d41d722cbd84)

SCRIPTS

Os scripts do nosso projeto servem para a movimentação, para os inimigos olharem para o personagem, para que caso ocorra alguma colisão aconteça algum evento e para manipular o som. assim controlamos todos os aspectos de colisão, menu, som para passos e gritos e a movimentação e do pulo.

PALETA DE CORES

As cores principais do Adoniran, dos monstros e do trem será azul, cinza, preto e tons de vermelho.
Azul-escuro representa o profissionalismo do personagem por ficar até tarde em seu trabalho porque precisaram de sua ajuda e por querer sustentar sua família, os zumbis usam o Azul para representar o profissionalismo do homem vindo o atormentar. Cinza é usado para a representação da neutralidade que o trem aparenta ter. O preto representa o Mal-estar que o personagem está sentido dentro dele Vermelho representa o perigo que os monstros representam para ele que são inimigos internos dele o atormentando. Temos os exemplos de cores:

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

[Sampa Midnight Instrumental](https://youtu.be/11ItVm6ZWdM?si=T9-wqq7uuSJTHX0-)

[Trem das Onze Intrumental](https://youtu.be/OoEgWsUQgaU?si=8sKqv3ZvsrWKxlSa)

[modelo Skeleton Ghost (FREE)](https://assetstore.unity.com/packages/3d/characters/creatures/skeleton-ghost-free-226070)

[modelo FREE low poly man – RPG Character](https://drive.google.com/file/d/17siYXt2FRVy5yzcm3_fSAh-YjbxZbwL5/view?usp=drive_link)

[modelo 3d dos corvos](https://assetstore.unity.com/packages/3d/characters/animals/birds/living-birds-15649)

[footstep - essentials](https://assetstore.unity.com/packages/audio/sound-fx/foley/footsteps-essentials-189879)

[video do jogo](https://drive.google.com/file/d/1RsIauDSYNOraNv735L36e_ENo8dDptZV/view?usp=drive_link)

[projeto completo](https://drive.google.com/file/d/17siYXt2FRVy5yzcm3_fSAh-YjbxZbwL5/view?usp=sharing)
