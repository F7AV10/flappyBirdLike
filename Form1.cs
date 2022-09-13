using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//////////////////////////////////////////////////////////////////////////////////////////
// EXERCICIO FEITO POR FLÁVIO NEVES - GITHUB https://github.com/F7AV10                  ///
// UMA CALCULADORA SIMPLES FEITA EM C# E WINFORMS, TESTANDO CONHECIMENTOS ADQUIRIDOS    ///
// COM O EXERCICIO DO PONG - https://github.com/F7AV10/pingPong                         ///
//////////////////////////////////////////////////////////////////////////////////////////

namespace flappyBird
{
    public partial class passaroVoador : Form
    {
        //VARIAVEIS
        Random randNum = new Random();
        //int frameAnim = 0;
        int pipeSpeed = 5;
        int gravity = 10;
        int score = 0;
        int nextScore = 5;

        public passaroVoador()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timerGame_Tick(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            //GERAR BG PROCEDURAL
            bgMontain1.Left -= randNum.Next(2, 5);
            bgMontain2.Left -= randNum.Next(2, 5);
            bgMontain3.Left -= randNum.Next(2, 5);
            bgNuvem1.Left -= randNum.Next(2, 5);
            bgNuvem2.Left -= randNum.Next(2, 5);
            bgNuvem3.Left -= randNum.Next(2, 5);
            //REPOSICIONA MONTANHAS
            if (bgMontain1.Left < -100)
            {
                bgMontain1.Left = randNum.Next(350, 450);
            }
            if (bgMontain2.Left < -120)
            {
                bgMontain2.Left = randNum.Next(450, 600);
            }
            if (bgMontain3.Left < -130)
            {
                bgMontain3.Left = randNum.Next(450, 600);
            }
            //REPOSICIONA NUVENS
            if (bgNuvem1.Left < -100)
            {
                bgNuvem1.Left = randNum.Next(360, 450);
            }
            if (bgNuvem2.Left < -100)
            {
                bgNuvem2.Left = randNum.Next(360, 450);
            }
            if (bgNuvem3.Left < -100)
            {
                bgNuvem3.Left = randNum.Next(360, 450);
            }

            //EFEITO GRAVIDADE / PERDER IMPULSO         
            if (gravity < 10)
            {
                gravity++;
            }

            //PLAYER
            playerBird.Top += gravity;
            playerColisor.Top = playerBird.Top + 12; 
            //CANOS 1
            pipeTop1.Left -= pipeSpeed;
            pipeBottom1.Left -= pipeSpeed;
            //CANOS 2
            pipeTop2.Left -= pipeSpeed;
            pipeBottom2.Left -= pipeSpeed;
            //SCORE LABEL
            scoreText.Text = "Score: " + score;
            labelNextScore.Text = "NextScore: " + nextScore;

            
            //LINHA DE CANOS 1
            if (pipeBottom1.Left < -100)
            {
                score++;
                pipeBottom1.Top = randNum.Next(150, 350);
                pipeBottom1.Left = 350;
                pipeTop1.Left = 350;
                pipeTop1.Top = pipeBottom1.Top - (pipeTop1.Height + 150);

            }
            //LINHA DE CANOS 2
            if (pipeBottom2.Left < -100)
            {
                score++;
                pipeBottom2.Top = randNum.Next(150, 350);
                pipeBottom2.Left = 350;
                pipeTop2.Left = 350;
                pipeTop2.Top = pipeBottom2.Top - (pipeTop2.Height + 150);

            }
            //AO ATINGIR nextScore ATUAL, ADICIONA 5 AO NOVO nextScore E AUMENTA A VELOCIDADE/DIFICULDADE DO JOGO (nextScore É UMA VARIAVEL QUE DEVINE O NIVEL ATUAL DO JOGO)
            if (score > nextScore)
            {
                nextScore += 5;
                pipeSpeed++;
            }


            //VERIFICA COLISÃO DO PLAYER COM CANO OU CHAO
            if (playerColisor.Bounds.IntersectsWith(pipeBottom1.Bounds) || playerColisor.Bounds.IntersectsWith(pipeTop1.Bounds) || playerColisor.Bounds.IntersectsWith(ground.Bounds) || playerColisor.Top < -15 || playerColisor.Bounds.IntersectsWith(pipeBottom2.Bounds) || playerColisor.Bounds.IntersectsWith(pipeTop2.Bounds))
            {
                endGame();
            }
            

        }

        private void gameKeyIsDown(object sender, KeyEventArgs e)
        {
            //IMPULSO
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10 ;
            }

        }
        //AÇÕES DO FIM DE JOGO
        private void endGame()
        {
            timerGame.Stop();
            scoreText.Text += " Game over!";
            scoreText.Top = 207;
            scoreText.Left = 42;
            gameOverScreen.Visible = true;
        }
    }
}
