<h1>E.T O Extraterrestre</h1>
<h3>Cena: Eliott e E.T. estão em fuga.</h3>
Trabalho feito por : Kauan de Carlo Merida e Matheus Henrique Galindo Campos.

 <h2>Proposta da atividade:</h2> 

Pegar uma cena específica de um filme e transformar em uma cena na Unity.


<h3>Cena desenvolvida</h3>
A cena começa com uma introdução ilustrativa, mostrando várias imagens em sequência para contextualizar o jogador, mesmo que ele não tenha visto o filme. Em seguida, o cenário abre com Eliott e E.T. em uma bicicleta sendo perseguidos pelos agentes do governo no meio da cidade. O jogador deve desviar dos obstáculos e escolher o caminho correto para não ser capturado. Ao completar o percurso, o jogador chega a uma rua sem saída, bloqueada por viaturas e agentes do governo. Nesse momento uma cutscene é ativada, mostrando a cena do filme em que a bicicleta voa na frente do sol, marcando o fim do jogo.
<br>
<br>

![IMG-20241129-WA0027.jpg](https://github.com/user-attachments/assets/ebd7277e-1a8b-43a7-a566-78061f70d3af)
 


<h2>Sobre o filme</h2> 
<br>

![Captura de tela 2024-11-21 114050](https://github.com/user-attachments/assets/600caea4-3243-4b1f-814a-3deb3fd9d768)

A história gira em torno de um alienígena chamado "E.T.", que é acidentalmente deixado na Terra por sua nave-mãe. Ele acaba sendo descoberto por um garoto solitário, Eliott, e nasce entre eles uma amizade profunda e emocionante, com Eliott tentando ajudar E.T. a retornar para o seu planeta natal enquanto o esconde das autoridades e cientistas que desejam estudá-lo.

A história de E.T. fala sobre amizade e aceitação. Eliott, que é apenas uma criança e não vê E.T. como uma ameaça ou algo estranho; ele só vê alguém que precisa de ajuda. Isso reflete a forma como as crianças, muitas vezes, são mais alertas e aceitam melhor o que é diferente, ao contrário dos adultos que tendem a ter medo ou querer controlar o que não conhecem. O filme nos lembra da importância de aceitar e entender quem é diferente de nós. Além disso, E.T. e Eliott têm uma conexão forte, mostrando que a amizade verdadeira não precisa de palavras e pode surgir entre seres completamente diferentes.

<h3>Análise dos personagens principais</h3>
<strong>Elliott</strong>: Um menino solitário e sonhador que se torna amigo de E.T. Sua jornada representa a inocência da infância e a busca por conexão emocional.

<strong>E.T.</strong>: um extraterrestre gentil e curioso que se perdeu na Terra. Ele simboliza a esperança e a amizade.

<strong>Gertie</strong>: A irmã mais nova de Elliott, que é espontânea e cheia de vida. Sua interação com E.T. traz um toque de leveza e humor à história.

<strong>Michael</strong>: O irmão mais velho de Elliott, que acaba se envolvendo na proteção do E.T. Sua evolução mostra o crescimento e a responsabilidade.

<strong>A Mãe de Elliott</strong>: Uma figura que representa o cuidado e a preocupação familiar, lidando com os desafios de criar os filhos sozinha.

<h2>Descrição técnica</h2>

<h3>Cenário</h3> 
Para fazer o cenário usamos os modelos grátis da loja do Unity e o Sketchfab. Para as construções da cidade usamos o modelo “CCity Building Set 1”, já para as árvores “Big Poplar Tree FREE” e “Big Oak Tree FREE”, para as texturas não foi preciso criar, utilizamos as texturas prontas dos assets baixados.
<br>

![IMG-20241125-WA0006.jpg](https://github.com/user-attachments/assets/ccedb43c-f842-4ecc-9db9-6265346c0733)
<br>

![Captura de tela 2024-11-27 103057](https://github.com/user-attachments/assets/2c7a20fe-cdd7-4d71-93a4-7b38f214dd76)
<br>

![Captura de tela 2024-11-27 103349](https://github.com/user-attachments/assets/86736a04-1105-4559-87a4-6b7bec8f633f)
<br>
<h3>Obstáculos</h3>
Para fazer os obstáculos usamos modelos grátis da loja do Unity. Para os arbustos usamos o modelo “Yughues Free Bushes” e os cones de trânsito, placas de sinalização e barreiras foi usado o modelo “Barrier & Traffic Cone Pack”. Utilizamos os arbustos para ter mais referência com o filme, onde a natureza é bem notável, para os materiais de construção foi usado para representar os perigos que estão nas ruas quando estão em construção que diversas das vezes resultam em acidentes e mortes todos os dias por conta de sinalização, falta de atenção e dirigir em alta velocidade.
<br>

![image](https://github.com/user-attachments/assets/5b7f1594-0976-4180-bd54-29123562dd13)
<br>

![Captura de tela 2024-11-27 103830](https://github.com/user-attachments/assets/b7e60857-10d3-443d-89ed-ea963e2b036e)
<br>

<h3>Personagem</h3>
Para os personagens usamos modelos grátis da loja do Unity e o Sketchfab. Para o jogador usamos o modelo do “E.T (Ofek,Sagiv,Abed)”, "Bike Ardis Verona 28" e "Relaxed Man Character". Para os agentes, usamos o modelo “Police Car & Helicopter”. Por fim, usamos Script C# para poder programar a movimentação do jogador, o trajeto do agente que persegue o jogador e as colisões.
<br>

![Captura de tela 2024-11-21 111308](https://github.com/user-attachments/assets/2774813b-64bd-4cc1-b5b3-f3c7a0109e80)
<br>

![Captura de tela 2024-11-21 111850](https://github.com/user-attachments/assets/3af1266b-34cc-4146-8e1a-e4820b4f7473)
<br>

![Captura de tela 2024-11-21 113016](https://github.com/user-attachments/assets/0f326dcc-d1f2-4be1-9a37-b5bdcc1bb788)
<br>

![Captura de tela 2024-11-21 113912](https://github.com/user-attachments/assets/a5ff03f3-0349-4542-8de5-fb703bba30b0)
<br>
<h2>Scripts</h2>

<h3>Player</h3>
Código:

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class player : MonoBehaviour<br>
{<br>
    public float speed;<br>
    public float lateralSpeed;<br>
    public float maxSpeed;<br>
    public float acceleration;<br>
    private Quaternion defaultRotation;<br>
    private Vector3 defaultPosition;<br>
    public float speedReduction;<br>

    // Start is called before the first frame update
    void Start()
    {
        defaultRotation = transform.rotation;
        defaultPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        increaseSpeed();
        movePlayer();
    }

    private void movePlayer()
    {
        // movimento para frente contínuo
        Vector3 forwardMovement = -Vector3.forward * speed * Time.deltaTime;

        float horizontalInput = Input.GetAxis("Horizontal");
        float adjustedLateralSpeed = lateralSpeed * (1 + speed / maxSpeed);
        Vector3 lateralMovement = -Vector3.right * horizontalInput * adjustedLateralSpeed * Time.deltaTime;

        transform.Translate(forwardMovement + lateralMovement);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Agent"))
        {
            resetPosition();
        }
    }

    private void resetPosition()
    {
        transform.position = defaultPosition; // A posição inicial do jogador
        transform.rotation = defaultRotation;         // A rotação original
        speed = 25;
    }

    private void increaseSpeed()
    {
        if (speed < maxSpeed)
        {
            speed += acceleration * Time.deltaTime;
        }
        else
        {
            speed = maxSpeed;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("bateu");
            reduceSpeed();
        }
    }
    private void reduceSpeed()
    {
        speed *= speedReduction;
    }
}

Sobre:

O código do player movimenta o jogador para frente continuamente e permite movimentos laterais baseados no comando do jogador. Também acelera gradualmente a velocidade até atingir um máximo, onde para limitar a velocidade máxima utilizamos um if e else. 
Reseta a posição e velocidade do jogador ao colidir com o agente, utilizamos o OnCollisionEnter para voltar às posições iniciais e por último, reduzimos a velocidade do jogador ao entrar em contato com um Obstáculo.

<h3>Agent</h3>
Código:

using UnityEngine;

public class agent : MonoBehaviour
{
    public Transform[] waypoints;
    public float speed = 5f;
    public float reachDistance = 0.5f; // Distância para considerar o waypoint alcançado

    private int currentWaypointIndex = 0; // Índice do waypoint atual

    private Quaternion defaultRotation;
    private Vector3 defaultPosition;

    void Start()
    {
        defaultRotation = transform.rotation;
        defaultPosition = transform.position;
    }
    void Update()
    {
        FollowPath();
    }

    private void FollowPath()
    {
        // Verifica se há waypoints definidos, caso contrário não executa o método
        if (waypoints.Length == 0) return;

        // Pega o waypoint atual
        Transform targetWaypoint = waypoints[currentWaypointIndex];

        // Move em direção ao waypoint atual
        Vector3 direction = (targetWaypoint.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;

        // Rotaciona a viatura para olhar para o waypoint
        transform.LookAt(targetWaypoint);

        // Verifica se a viatura alcançou o waypoint
        if (Vector3.Distance(transform.position, targetWaypoint.position) <= reachDistance)
        {
            currentWaypointIndex++; // Passa para o próximo waypoint
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Reseta a posição do agent para a posição inicial
            resetPosition();
        }
    }

    private void resetPosition()
    {
        transform.position = defaultPosition;
        transform.rotation = defaultRotation;
        currentWaypointIndex = 0;
    }
}

Sobre:
 
No código do agente temos as principais funções como: Movimento entre waypoints. Onde o agente se move continuamente em direção ao waypoint atual e rotaciona para "olhar" na direção do waypoint, para ele olhar para o waypoint utilizamos "lookAt". Também usamos detecção de colisão com o jogador. Se o agente colidir com um objeto marcado com a tag "Player", ele retorna à sua posição e rotação iniciais e reinicia o percurso desde o primeiro waypoint. Por fim, o reset da posição inicial onde armazena a posição e rotação iniciais do agente para restaurar quando necessário.

<h3>Wall</h3>
Código:

using UnityEngine;

public class Walls : MonoBehaviour
{
    public Transform playerObject; // Referência ao jogador
    public Transform agentObject; // Referência ao agent
    private Vector3 playerStartPos; // Posição inicial do jogador
    private Vector3 targetStartPos; // Posição inicial do agent


    private void Start()
    {
        // Armazena as posições iniciais, se não forem configuradas manualmente
        if (playerObject != null) playerStartPos = playerObject.position;
        if (agentObject != null) targetStartPos = agentObject.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Verifica se o jogador colidiu
        if (collision.gameObject.CompareTag("Player"))
        {
            // Reseta as posições
            if (playerObject != null)
            {
                player playerScript = playerObject.GetComponent<player>();
                if (playerScript != null)
                {
                    playerScript.resetPosition();
                }
                if (agentObject != null)
                {
                    agent agentScript = agentObject.GetComponent<agent>();
                    if (agentScript != null)
                    {
                        agentScript.resetPosition();
                    }
                }
            }
        }
    }
}

Sobre:
Utilizamos esse código nas paredes para que o jogador não saia para fora da pista, caso o jogador entre em colisão com a parede ele retorna à posição e rotação iniciais e reinicia o waypoint do agente recomeçando o jogo.

<h2> Diagrama de classes</h2>
<h3>Antigo:</h3>
<br>

![IMG-20241201-WA0006.jpg](https://github.com/user-attachments/assets/4da36991-b0fa-4dec-9542-5e1038465c59)<br>

<h3>Atualizado:</h3>
<br>

<img width="1648" alt="Untitled" src="https://github.com/user-attachments/assets/4a017d2c-7cd2-4ce2-9a75-dfde77f67fb4"><br>

<h2>Paleta de cores</h2>
As cores principais do jogador, dos obstáculos e da cidade são tons de cinza, marrom, verde, azul escuro e laranja. Sendo o cinza para representar o realismo e a seriedade que está presente na cena da fuga, o marrom que representa o conforto e segurança que o E.T. e Eliott sentem ao estar juntos, o verde representa a natureza, crescimento e esperança, o azul escuro o suspense, tensão e o mistério que tem no filme; e o laranja simbolizando o perigo, tensão e urgência dando à cena mais emoção e adrenalina.
 <br>

<img width="296" alt="image" src="https://github.com/user-attachments/assets/2efe0aeb-b174-465c-bfc4-c6a5c484a710">
<br>
Cor: Azul escuro<br>
Codigo hex:#353c81

<img width="295" alt="image" src="https://github.com/user-attachments/assets/199f1889-793e-4fb3-956d-a169ce84f8a2"><br>
Cor: Cinza<br>
Codigo hex:#72757a

![image](https://github.com/user-attachments/assets/f091d35d-bc5b-4500-bf07-6fee1d08ae06)
<br>
Cor: Laranja<br>
Cidigo hex:#ff5518

<img width="292" alt="image" src="https://github.com/user-attachments/assets/6ca182d1-f907-4675-88cd-80878cce826a">
<br>
Cor: Marrom<br>
Codigo hex:#875e41

![Captura de tela 2024-11-27 101912](https://github.com/user-attachments/assets/668b3248-7325-4814-ab27-7645cb649029)
<br>
Cor: Verde<br>
Codigo hex:#85965b

<h2>Links da Asset Store e referências</h2>

https://assetstore.unity.com/packages/3d/vegetation/plants/yughues-free-bushes-13168

https://assetstore.unity.com/packages/3d/vegetation/big-poplar-tree-free-301037

https://assetstore.unity.com/packages/3d/vegetation/big-oak-tree-free-279431

https://assetstore.unity.com/packages/3d/environments/barrier-traffic-cone-pack-82549

https://assetstore.unity.com/packages/3d/characters/humanoids/fantasy/relaxed-man-character-32665

https://assetstore.unity.com/packages/3d/vehicles/land/police-car-helicopter-52496

https://sketchfab.com/3d-models/ccity-building-set-1-a2d5c7bfcc2148fb8994864c43dfcc97

https://sketchfab.com/3d-models/bike-ardis-verona-28-99d6dce2e49e4ba185ac108ab044524d

https://sketchfab.com/3d-models/et-ofeksagivabed-45794dfae500422c928d0470dbaa5918
<br>
<h2>Projeto no Drive</h2>
https://drive.google.com/drive/folders/1xziQuVGvPPf68psh5-PgAo_Oi9ejgUjD?usp=drive_link
<br>
<h2>Relatório do trabalho</h2>
<strong>Kauan:</strong> Responsável pelo jogo em si, mecânicas e parte lógica. (Fez os scripts, cenário no Unity, as mecânicas do jogo e os detalhes como decoração, iluminação, etc).
<br>
<strong>Matheus:</strong> Responsável pela documentação e design. (Fez a documentação do GitHub, decidiu os assets/referências para o jogo e participou do processo criativo).
