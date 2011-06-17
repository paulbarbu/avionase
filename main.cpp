#include <iostream>
#include <stdio.h>
#include <stdlib.h>
#include <ncurses.h>
#include "inc/fmod.hpp"

using namespace std;
using namespace FMOD;

Channel *channel;

Sound *sound;
System::init()

int GetRand(int min, int max) /* http://faq.cprogramming.com/cgi-bin/smartfaq.cgi?answer=1042005782&id=1043284385  */
{
  static int Init = 0;
  int rc;

  if (Init == 0)
  {
    /*
     *  As Init is static, it will remember it's value between
     *  function calls.  We only want srand() run once, so this
     *  is a simple way to ensure that happens.
     */
    srand(time(NULL));
    Init = 1;
  }

  /*
   * Formula:
   *    rand() % N   <- To get a number between 0 - N-1
   *    Then add the result to min, giving you
   *    a random number between min - max.
   */
  rc = (rand() % (max - min + 1) + min);

  return (rc);
}

void breakTime( float seconds)   /* http://www.cplusplus.com/forum/beginner/12254/ */
{
    clock_t temp;
    temp = clock () + seconds * CLOCKS_PER_SEC ;
    while (clock() < temp) {}
}



int a[9][9];                       //matricia pe care desenez avioanele

int main()
{
    int i, j, x=0, y=0, avion=3, x1, y1, x2, y2, x3, y3, a1, a2, a3, generat2=0, generat3=0, input, x_nou=0, ya, xa;

    char b[9][9];                 //matricea cu caractere unde loveste jucatorul

    for(i=0;i<9;i++)              //umplu matricea cu #-uri
        for(j=0;j<9;j++)
            b[i][j]='#';

    //avionul 1
    //randomizare a1,x1, y1;
    a1=GetRand(1, 4);

    if(a1==1){
        x1=GetRand(2, 6);
        y1=GetRand(0, 5);
    }
    else if(a1==2){
        x1=GetRand(3, 8);
        y1=GetRand(2, 6);
    }
    else if(a1==3){
        x1=GetRand(2, 6);
        y1=GetRand(3, 8);
    }
    else if(a1==4){
        x1=GetRand(0, 5);
        y1=GetRand(2, 6);
    }

    i=y1;
    j=x1;

    if(a1==1){  //varful in sus, este primul avion si nu are nevoie de verificari
        a[i][j]=5;
        a[i+1][j-2]=a[i+1][j-1]=a[i+1][j]=a[i+1][j+1]=a[i+1][j+2]=a[i+2][j]=a[i+3][j-1]=a[i+3][j]=a[i+3][j+1]=1;
    }
    else if(a1==2){ //varful la dreapta
        a[i][j]=5;
        a[i-2][j-1]=a[i-1][j-1]=a[i][j-1]=a[i+1][j-1]=a[i+2][j-1]=a[i][j-2]=a[i-1][j-3]=a[i][j-3]=a[i+1][j-3]=1;
    }
    else if(a1==3){//varful in jos
        a[i][j]=5;
        a[i-1][j-2]=a[i-1][j-1]=a[i-1][j]=a[i-1][j+1]=a[i-1][j+2]=a[i-2][j]=a[i-3][j-1]=a[i-3][j]=a[i-3][j+1]=1;
    }
    else{ //varful in stanga
        a[i][j]=5;
        a[i-2][j+1]=a[i-1][j+1]=a[i][j+1]=a[i+1][j+1]=a[i+2][j+1]=a[i][j+2]=a[i-1][j+3]=a[i][j+3]=a[i+1][j+3]=1;
    }

    //avionul 2
    while(!generat2){
        //randomizare a2, x2, y2;
        a2=GetRand(1, 4);

        if(a2==1){
            x2=GetRand(2, 6);
            y2=GetRand(0, 5);
        }
        else if(a2==2){
            x2=GetRand(3, 8);
            y2=GetRand(2, 6);
        }
        else if(a2==3){
            x2=GetRand(2, 6);
            y2=GetRand(3, 8);
        }
        else if(a2==4){
            x2=GetRand(0, 5);
            y2=GetRand(2, 6);
        }

        i=y2;
        j=x2;

        if(a2==1)  //varful in sus
            if(a[i][j]==0 && a[i+1][j-2]==0 && a[i+1][j-1]==0 && a[i+1][j]==0 &&a[i+1][j+1]==0 && a[i+1][j+2]==0 && a[i+2][j]==0 && a[i+3][j-1]==0 && a[i+3][j]==0 && a[i+3][j+1]==0){
                a[i][j]=6;
                a[i+1][j-2]=a[i+1][j-1]=a[i+1][j]=a[i+1][j+1]=a[i+1][j+2]=a[i+2][j]=a[i+3][j-1]=a[i+3][j]=a[i+3][j+1]=2;
                generat2=1;
            }

        else if(a2==2) //varful la dreapta
            if(a[i][j]==a[i-2][j-1]==a[i-1][j-1]==a[i][j-1]==a[i+1][j-1]==a[i+2][j-1]==a[i][j-2]==a[i-1][j-3]==a[i][j-3]==a[i+1][j-3]==0){
                a[i][j]=6;
                a[i-2][j-1]=a[i-1][j-1]=a[i][j-1]=a[i+1][j-1]=a[i+2][j-1]=a[i][j-2]=a[i-1][j-3]=a[i][j-3]=a[i+1][j-3]=2;
                generat2=1;
            }

        else if(a2==3)//varful in jos
            if(a[i][j]==a[i-1][j-2]==a[i-1][j-1]==a[i-1][j]==a[i-1][j+1]==a[i-1][j+2]==a[i-2][j]==a[i-3][j-1]==a[i-3][j]==a[i-3][j+1]==0){
                a[i][j]=6;
                a[i-1][j-2]=a[i-1][j-1]=a[i-1][j]=a[i-1][j+1]=a[i-1][j+2]=a[i-2][j]=a[i-3][j-1]=a[i-3][j]=a[i-3][j+1]=2;
                generat2=1;
            }
        else if(a2==4)//varful la stanga
            if(a[i][j]==a[i-2][j+1]==a[i-1][j+1]==a[i][j+1]==a[i+1][j+1]==a[i+2][j+1]==a[i][j+2]==a[i-1][j+3]==a[i][j+3]==a[i+1][j+3]==0){
                a[i][j]=6;
                a[i-2][j+1]=a[i-1][j+1]=a[i][j+1]=a[i+1][j+1]=a[i+2][j+1]=a[i][j+2]=a[i-1][j+3]=a[i][j+3]=a[i+1][j+3]=2;
                generat2=1;
            }
        else //incearca alte randomizari
            generat2=0;
    }

    //avionul 3
    while(!generat3){
        //randomizare a3, x3, y3;
        a3=GetRand(1, 4);

        if(a3==1){
            x3=GetRand(2, 6);
            y3=GetRand(0, 5);
        }
        else if(a3==2){
            x3=GetRand(3, 8);
            y3=GetRand(2, 6);
        }
        else if(a3==3){
            x3=GetRand(2, 6);
            y3=GetRand(3, 8);
        }
        else if(a3==4){
            x3=GetRand(0, 5);
            y3=GetRand(2, 6);
        }

        i=y3;
        j=x3;


        if(a3==1)  //varful in sus
            if(a[i][j]==0 && a[i+1][j-2]==0 && a[i+1][j-1]==0 && a[i+1][j]==0 &&a[i+1][j+1]==0 && a[i+1][j+2]==0 && a[i+2][j]==0 && a[i+3][j-1]==0 && a[i+3][j]==0 && a[i+3][j+1]==0){
                a[i][j]=7;
                a[i+1][j-2]=a[i+1][j-1]=a[i+1][j]=a[i+1][j+1]=a[i+1][j+2]=a[i+2][j]=a[i+3][j-1]=a[i+3][j]=a[i+3][j+1]=3;
                generat3=1;
            }

        else if(a3==2) //varful la dreapta
            if(a[i][j]==a[i-2][j-1]==a[i-1][j-1]==a[i][j-1]==a[i+1][j-1]==a[i+2][j-1]==a[i][j-2]==a[i-1][j-3]==a[i][j-3]==a[i+1][j-3]==0){
                a[i][j]=7;
                a[i-2][j-1]=a[i-1][j-1]=a[i][j-1]=a[i+1][j-1]=a[i+2][j-1]=a[i][j-2]=a[i-1][j-3]=a[i][j-3]=a[i+1][j-3]=3;
                generat3=1;
            }

        else if(a3==3)//varful in jos
            if(a[i][j]==a[i-1][j-2]==a[i-1][j-1]==a[i-1][j]==a[i-1][j+1]==a[i-1][j+2]==a[i-2][j]==a[i-3][j-1]==a[i-3][j]==a[i-3][j+1]==0){
                a[i][j]=7;
                a[i-1][j-2]=a[i-1][j-1]=a[i-1][j]=a[i-1][j+1]=a[i-1][j+2]=a[i-2][j]=a[i-3][j-1]=a[i-3][j]=a[i-3][j+1]=3;
                generat3=1;
            }
        else if(a3==4)//varful la stanga
            if(a[i][j]==a[i-2][j+1]==a[i-1][j+1]==a[i][j+1]==a[i+1][j+1]==a[i+2][j+1]==a[i][j+2]==a[i-1][j+3]==a[i][j+3]==a[i+1][j+3]==0){
                a[i][j]=7;
                a[i-2][j+1]=a[i-1][j+1]=a[i][j+1]=a[i+1][j+1]=a[i+2][j+1]=a[i][j+2]=a[i-1][j+3]=a[i][j+3]=a[i+1][j+3]=3;
                generat3=1;
            }
        else //incearca alte randomizari
            generat3=0;
    }


initscr();
noecho();
clear();

	for(i=0;i<9;i++){             //ii afisez jucatorului matricea goala ca sa aiba o idee unde sa loveasca
		for(j=0;j<9;j++){
			printw("%c ", b[i][j]);
			refresh();
        }
			printw("\n");
			refresh();
    }
    while(avion){
		do{
		    refresh();
		    move(4, 20);
		    //refresh();
            printw("Esti la coordonatele x=%d si y=%d.", x+1, y+1);

            move(y, x_nou);
            refresh();
            //refresh();

            if(x_nou%2==0){
                move(y, x_nou);
                printw("%c", 32);
                refresh();
                move(y, x_nou);
                //refresh();
            }

			input = getch();
			//if(input !=120)
              //  input = getch();

			if(input == 65) //sus

				if(y>=0 && y<=8){
                    y--;
                    move(y, x_nou);
                    //refresh();
                }
				else
					y=8;

			else if(input == 66) //jos
				if(y>=0 && y+1<=8){//daca ma duc mai in jos de atat y devine mai mare decat 9, deci trebuie sa trec pe primul rand(adica y vine deja egal cu 8)
					y++;
                    move(y, x_nou);
                    //refresh();
				}
				else
					y=0; //aici trec pe primul rand
			else if(input == 68)//stanga
				if(x>=0 && x<=8 && x_nou>=0 && x_nou<=16){ //daca x si x_nou devin <0 atunci trec pe partea dreapta
					x--;
					x_nou-=2;
					move(y, x_nou);
					//refresh();
				}
				else{
					x_nou=16; //aici trec pe partea dreapta
                    x=8;
				}
			else if(input == 67)//dreapta
				if(x>=0 && x<=8 && x_nou>=0 && x_nou+2<=16){ //daca x_nou decvine mai mare decat 18 atunci trebuie sa terc pe stanga si vine mai mare decat 18 datorida if-ului din switch
					x++;
					x_nou+=2;
					move(y, x_nou);
					//refresh();

				}
                else{
                    x_nou=0; //aici trec pe stanga
                    x=0;
                }
           // refresh();

            switch(input){
                case 65: //sus
                if(y>=-1 && y<8){// ca sa merg in sus inseamna ca am venit de jos, deci afisez # un rand mai jos, iar daca y ajunge aici ca 8 atunci nu mai am unde afisa ca insemna ca am ajuns deja pe ultimul rand(n-am randuri mai jos) si continui asa, cu y=8;
                    move(y+1, x_nou);
                    //refresh();
                    switch(b[x][y+1]){
                        case '^':
                            printw("%c", '^');
                            refresh();
                            break;
                        case '>':
                            printw("%c", '>');
                            refresh();
                            break;
                        case 'v':
                            printw("%c", 'v');
                            refresh();
                            break;
                        case '<':
                            printw("%c", '<');
                            refresh();
                            break;
                        case 'O':
                            printw("%c", 'O');
                            refresh();
                            break;
                        case 'M':
                            printw("%c", 'M');
                            refresh();
                            break;
                        case 'B':
                            printw("%c", 'B');
                            refresh();
                            break;
                        case 'A':
                            printw("%c", 'A');
                            refresh();
                            break;
                        default:
                            printw("%c", 35);
                            refresh();
                    }
                    move(y+1, x_nou);
                    //refresh();
                    break;
                }
                else
                    y=8; //pastrez valoarea astfel incat cand y incearca sa treca iar de primul if, e respinsa si devine 0, astfel am trecut la primul rand


                case 66: //jos
                    move(y-1, x_nou);
                    //refresh();
                    switch(b[x][y-1]){
                        case '^':
                            printw("%c", '^');
                            refresh();
                            break;
                        case '>':
                            printw("%c", '>');
                            refresh();
                            break;
                        case 'v':
                            printw("%c", 'v');
                            refresh();
                            break;
                        case '<':
                            printw("%c", '<');
                            refresh();
                            break;
                        case 'O':
                            printw("%c", 'O');
                            refresh();
                            break;
                        case 'M':
                            printw("%c", 'M');
                            refresh();
                            break;
                        case 'B':
                            printw("%c", 'B');
                            refresh();
                            break;
                        case 'A':
                            printw("%c", 'A');
                            refresh();
                            break;
                        default:
                            printw("%c", 35);
                            refresh();
                    }
                    move(y-1, x_nou);
                    //refresh();
                    break;

                case 68: //stanga
                if(x_nou<16 && x>=-1){ //ca sa merg in stanga inseamna sa scriu # de unde am venit(dreapta), iar daca x_nou e deja 16 nu mai am unde sa scriu si continui cu x=8 si x_nou=16 ca sa evit scrierea
                    move(y, x_nou+2);
                    //refresh();
                    switch(b[x+1][y]){
                        case '^':
                            printw("%c", '^');
                            refresh();
                            break;
                        case '>':
                            printw("%c", '>');
                            refresh();
                            break;
                        case 'v':
                            printw("%c", 'v');
                            refresh();
                            break;
                        case '<':
                            printw("%c", '<');
                            refresh();
                            break;
                        case 'O':
                            printw("%c", 'O');
                            refresh();
                            break;
                        case 'M':
                            printw("%c", 'M');
                            refresh();
                            break;
                        case 'B':
                            printw("%c", 'B');
                            refresh();
                            break;
                        case 'A':
                            printw("%c", 'A');
                            refresh();
                            break;
                        default:
                            printw("%c", 35);
                            refresh();
                    }
                    move(y, x_nou+2);
                    //refresh();
                    break;
                }
                else{
                    x=8;
                    x_nou=16;//pastrez valorile ca sa nu mai treaca de verificarea din if-ul //dreapta, iar apoi se va face trecerea la stanga
                }

                case 67: //dreapta
                    move(y, x_nou-2);
                    //refresh();
                    switch(b[x-1][y]){
                        case '^':
                            printw("%c", '^');
                            refresh();
                            break;
                        case '>':
                            printw("%c", '>');
                            refresh();
                            break;
                        case 'v':
                            printw("%c", 'v');
                            refresh();
                            break;
                        case '<':
                            printw("%c", '<');
                            refresh();
                            break;
                        case 'O':
                            printw("%c", 'O');
                            refresh();
                            break;
                        case 'M':
                            printw("%c", 'M');
                            refresh();
                            break;
                        case 'B':
                            printw("%c", 'B');
                            refresh();
                            break;
                        case 'A':
                            printw("%c", 'A');
                            refresh();
                            break;
                        default:
                            printw("%c", 35);
                            refresh();
                    }
                    move(y, x_nou-2);
                    //refresh();
                    break;
            }
            refresh();

                FMUSIC_StopSong(handle);
                handle=FMUSIC_LoadSong("/home/paullik/mutare.wav");
                FMUSIC_PlaySong(handle);
		}while(input != 120);

		xa=y;
		ya=x;

        switch(a[xa][ya]){
            case 4: //verific sa nu se mai fi lovit acel punct de pe matrice
                move(2, 20);
                printw("\t\t\t\t\t\t");
                refresh();
                breakTime(0.2);
                move(2, 20);
                printw("Ai mai lovit o data aici!\t\t");
                refresh();
                /////////////////////////////////////////////////////////////////////////////
                break;

            case 5: //loviturile mortale pt. avioane si semnele in care sunt intreptate varfurile
                move(2, 20);
                printw("\t\t\t\t\t\t");
                refresh();
                breakTime(0.2);
                move(2, 20);
                printw("Lovitura mortala pt. avionul 1!");//cout<<"Lovitura mortala pt. avionul 1!"<<endl<<endl;
                refresh();
                //////////////////////////////////////////////////////////////////////////////grenada
                FMUSIC_StopSong(handle);
                handle=FMUSIC_LoadSong("/home/paullik/doborat.wav");
                FMUSIC_PlaySong(handle);
                    avion--; //daca un avion este doborat mai raman doua si tot asa..pana la 0, unde se inchieie jocul
                    a[xa][ya]=4;  //nu pot lovi in varf de 2 ori
                    switch(a1){
                        case 1: b[x][y]='^';
                            break;
                        case 2: b[x][y]='>';
                            break;
                        case 3: b[x][y]='v';
                            break;
                        case 4: b[x][y]='<';
                    }
                break;

            case 6:
                move(2, 20);
                printw("\t\t\t\t\t\t");
                refresh();
                breakTime(0.2);
                move(2, 20);
                printw("Lovitura mortala pt. avionul 2!");//cout<<"Lovitura mortala pt. avionul 2!"<<endl<<endl;
                refresh();
                //////////////////////////////////////////////////////////////////////////////grenada
                FMUSIC_StopSong(handle);
                handle=FMUSIC_LoadSong("/home/paullik/doborat.wav");
                FMUSIC_PlaySong(handle);
                    avion--;
                    a[xa][ya]=4;
                    switch(a2){
                        case 1: b[x][y]='^';
                            break;
                        case 2: b[x][y]='>';
                            break;
                        case 3: b[x][y]='v';
                            break;
                        case 4: b[x][y]='<';
                    }
                break;

            case 7:
                move(2, 20);
                printw("\t\t\t\t\t\t");
                refresh();
                breakTime(0.2);
                move(2, 20);
                printw("Lovitura mortala pt. avionul 3!");//cout<<"Lovitura mortala pt. avionul 3!"<<endl<<endl;
                refresh();
                //////////////////////////////////////////////////////////////////////////////grenada
                FMUSIC_StopSong(handle);
                handle=FMUSIC_LoadSong("/home/paullik/doborat.wav");
                FMUSIC_PlaySong(handle);
                    avion--;
                    a[xa][ya]=4;
                    switch(a3){
                        case 1: b[x][y]='^';
                            break;
                        case 2: b[x][y]='>';
                            break;
                        case 3: b[x][y]='v';
                            break;
                        case 4: b[x][y]='<';
                    }
                break;

            case 1:
                move(2, 20);
                printw("\t\t\t\t\t\t");
                refresh();
                breakTime(0.2);
                move(2, 20);
                printw("Avionul 1 a fost lovit.\t\t");//cout<<"Avionul 1 a fost lovit."<<endl<<endl; //tipul de avion care a fost lovit
                refresh();
                //////////////////////////////////////////////////////////////////////////////shot
                FMUSIC_StopSong(handle);
                handle=FMUSIC_LoadSong("/home/paullik/lovit.wav");
                FMUSIC_PlaySong(handle);
						b[x][y]='A';  //semnul specific
						a[xa][ya]=4;    //marcajul ca sa pot face verificare pt dubla-lovitura
                break;

            case 2:
                move(2, 20);
                printw("\t\t\t\t\t\t");
                refresh();
                breakTime(0.2);
                move(2, 20);
                printw("Avionul 2 a fost lovit.\t\t");//cout<<"Avionul 2 a fost lovit."<<endl<<endl;
                refresh();
                //////////////////////////////////////////////////////////////////////////////shot
                FMUSIC_StopSong(handle);
                handle=FMUSIC_LoadSong("/home/paullik/lovit.wav");
                FMUSIC_PlaySong(handle);
						b[x][y]='B';
						a[xa][ya]=4;
                break;

            case 3:
                move(2, 20);
                printw("\t\t\t\t\t\t");
                refresh();
                breakTime(0.2);
                move(2, 20);
                printw("Avionul 3 a fost lovit.\t\t");//cout<<"Avionul 3 a fost lovit."<<endl<<endl;
                refresh();
                //////////////////////////////////////////////////////////////////////////////shot
                FMUSIC_StopSong(handle);
                handle=FMUSIC_LoadSong("/home/paullik/lovit.wav");
                FMUSIC_PlaySong(handle);
						b[x][y]='M';
						a[xa][ya]=4;
                break;

            default:
                move(2, 20);//daca nu este prezenta o bucata de avion si jucatorul a lovit acolo notez locul cu @
                printw("\t\t\t\t\t\t");
                refresh();
                breakTime(0.2);
                move(2, 20);
                printw("Liber\t\t\t\t");//cout<<"Liber"<<endl<<endl;
                refresh();
                //////////////////////////////////////////////////////////////////////////////
                FMUSIC_StopSong(handle);
                handle=FMUSIC_LoadSong("/home/paullik/liber.wav");
                FMUSIC_PlaySong(handle);
                    b[x][y]='O';
                    a[xa][ya]=4;
        }
        refresh();
			breakTime(0.7);
    }
    clear();
    move(4, 8);
    //refresh();
    ////////////////////////////////////////////////////////////////////////////// applauze
    FMUSIC_StopSong(handle);
    handle=FMUSIC_LoadSong("/home/paullik/aplauze.wav");
    FMUSIC_PlaySong(handle);
    printw("Avioane doborate!!!");//cout<<"Avioane doborate!!!"; //aici cand am iesit din while inseamna ca avionul a fost doborat si e gata jocul
    refresh();
    breakTime(5.0);

    FMUSIC_FreeSong (handle);
    FSOUND_Close();

    endwin();



    return 0;
}
