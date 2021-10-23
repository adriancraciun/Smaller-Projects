#include "mainwindow.h"
#include "ui_mainwindow.h"
#include <QFileDialog>
#include <QDesktopWidget>
#include <QPixmap>
#include <QPalette>
#include <QAction>
#include <QToolBar>
#include <QMessageBox>
#include <QDesktopServices>
#include <QUrl>

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow),
    menuDomesticAnimals {new QMenu(this)},
    menuWildAnimals {new QMenu(this)},
    menuBirds {new QMenu(this)},
    actDog {new QAction(this)},
    actCat {new QAction(this)},
    actFish {new QAction(this)},
    actTurtle {new QAction(this)},
    actLeo {new QAction(this)},
    actAlligator {new QAction(this)},
    actHorse {new QAction(this)},
    actCow {new QAction(this)},
    actPig {new QAction(this)},
    actTiger {new QAction(this)},
    actSheep {new QAction(this)},
    actRabbit {new QAction(this)},
    actGoat {new QAction(this)},
    actChicken {new QAction(this)},
    actDonkey {new QAction(this)},
    actDuck {new QAction(this)},
    actGoose {new QAction(this)},
    actTurkey {new QAction(this)},
    actFox {new QAction(this)},
    actBear {new QAction(this)},
    actSnake {new QAction(this)},
    actMoose {new QAction(this)},
    actWolf {new QAction(this)},
    actOwl {new QAction(this)},
    actEagle {new QAction(this)},
    actRat {new QAction(this)},
    actPenguin {new QAction(this)},
    actCrow {new QAction(this)}
{
    ui->setupUi(this);
    this->move(QApplication::desktop()->screen()->rect().center() - this->rect().center());
    QPixmap pix1(":/Images/Images/BearWinterImage.jpg");
    QPixmap pix2(":/Images/Images/FoxWinterImage.jpg");
    ui->labelPicture1->setPixmap(pix1.scaled(400, 400));
    ui->labelPicture2->setPixmap(pix2.scaled(400, 400));

    QPixmap bkgnd(":/Images/Images/Background2.jpg");
    bkgnd = bkgnd.scaled(this->size(), Qt::IgnoreAspectRatio);
    QPalette palette;
    palette.setBrush(QPalette::Background, bkgnd);
    this->setPalette(palette);

    menuDomesticAnimals->setTitle(tr("&DomesticAnimals"));
    menuWildAnimals->setTitle(tr("&WildAnimals"));
    menuBirds->setIcon(QIcon(":/Images/Images/BirdIcon.png"));

    actDog->setText("&Dog");
    actDog->setIcon(QIcon(":/Images/Images/DogIcon.png"));
    actCat->setText("&Cat");
    actCat->setIcon(QIcon(":/Images/Images/CatIcon.jpg"));
    actFish->setText("&Fish");
    actFish->setIcon(QIcon(":/Images/Images/FishIcon.png"));
    actTurtle->setText("&Turtle");
    actTurtle->setIcon(QIcon(":/Images/Images/TurtleIcon.png"));
    actLeo->setText("&Leo");
    actLeo->setIcon(QIcon(":/Images/Images/LeoIcon.png"));
    actAlligator->setText("&Alligator");
    actAlligator->setIcon(QIcon(":/Images/Images/AlligatorIcon.png"));
    actHorse->setText("&Horse");
    actHorse->setIcon(QIcon(":/Images/Images/HorseIcon.png"));
    actCow->setText("&Cow");
    actCow->setIcon(QIcon(":/Images/Images/CowIcon.png"));
    actPig->setText("&Pig");
    actPig->setIcon(QIcon(":/Images/Images/PigIcon.png"));
    actTiger->setText("&Tiger");
    actTiger->setIcon(QIcon(":/Images/Images/TigerIcon.jpg"));
    actSheep->setText("&Sheep");
    actSheep->setIcon(QIcon(":/Images/Images/SheepIcon.jpg"));
    actRabbit->setText("&Rabbit");
    actRabbit->setIcon(QIcon(":/Images/Images/RabbitIcon.jpg"));
    actGoat->setText("&Goat");
    actGoat->setIcon(QIcon(":/Images/Images/GoatIcon.png"));
    actChicken->setText("&Chicken");
    actChicken->setIcon(QIcon(":/Images/Images/ChickenIcon.jpg"));
    actDonkey->setText("&Donkey");
    actDonkey->setIcon(QIcon(":/Images/Images/DonkeyIcon.png"));
    actDuck->setText("&Duck");
    actDuck->setIcon(QIcon(":/Images/Images/DuckIcon.png"));
    actGoose->setText("&Goose");
    actGoose->setIcon(QIcon(":/Images/Images/GooseIcon.png"));
    actTurkey->setText("&Turkey");
    actTurkey->setIcon(QIcon(":/Images/Images/TurkeyIcon.png"));
    actFox->setText("&Fox");
    actFox->setIcon(QIcon(":/Images/Images/FoxIcon.jpg"));
    actBear->setText("&Bear");
    actBear->setIcon(QIcon(":/Images/Images/BearIcon.png"));
    actSnake->setText("&Snake");
    actSnake->setIcon(QIcon(":/Images/Images/SnakeIcon.png"));
    actMoose->setText("&Moose");
    actMoose->setIcon(QIcon(":/Images/Images/MooseIcon.png"));
    actWolf->setText("&Wolf");
    actWolf->setIcon(QIcon(":/Images/Images/WolfIcon.png"));
    actOwl->setText("&Owl");
    actOwl->setIcon(QIcon(":/Images/Images/OwlIcon.png"));
    actEagle->setText("&Eagle");
    actEagle->setIcon(QIcon(":/Images/Images/EagleIcon.png"));
    actRat->setText("&Rat");
    actRat->setIcon(QIcon(":/Images/Images/RatIcon.png"));
    actPenguin->setText("&Penguin");
    actPenguin->setIcon(QIcon(":/Images/Images/PenguinIcon.png"));
    actCrow->setText("&Crow");
    actCrow->setIcon(QIcon(":/Images/Images/CrowIcon.png"));


    menuDomesticAnimals->addAction(actDog);
    menuDomesticAnimals->addSeparator();
    menuDomesticAnimals->addAction(actCat);
    menuDomesticAnimals->addAction(actCow);
    menuDomesticAnimals->addAction(actSheep);
    menuDomesticAnimals->addAction(actRabbit);
    menuDomesticAnimals->addAction(actHorse);
    menuDomesticAnimals->addAction(actCow);
    menuDomesticAnimals->addAction(actGoat);
    menuDomesticAnimals->addAction(actChicken);
    menuDomesticAnimals->addAction(actDonkey);
    menuDomesticAnimals->addAction(actDuck);
    menuDomesticAnimals->addAction(actGoose);
    menuDomesticAnimals->addAction(actTurkey);


    menuWildAnimals->addAction(actFish);
    menuWildAnimals->addAction(actTurtle);
    menuWildAnimals->addAction(actAlligator);
    menuWildAnimals->addAction(actTiger);
    menuWildAnimals->addAction(actRabbit);
    menuWildAnimals->addAction(actLeo);
    menuWildAnimals->addAction(actHorse);
    menuWildAnimals->addAction(actGoat);
    menuWildAnimals->addAction(actDuck);
    menuWildAnimals->addAction(actGoose);
    menuWildAnimals->addAction(actTurkey);
    menuWildAnimals->addAction(actFox);
    menuWildAnimals->addAction(actBear);
    menuWildAnimals->addAction(actSnake);
    menuWildAnimals->addAction(actMoose);
    menuWildAnimals->addAction(actWolf);
    menuWildAnimals->addAction(actOwl);
    menuWildAnimals->addAction(actEagle);
    menuWildAnimals->addAction(actRat);
    menuWildAnimals->addAction(actPenguin);
    menuWildAnimals->addAction(actCrow);


    menuBirds->addAction(actChicken);
    menuBirds->addAction(actDuck);
    menuBirds->addAction(actGoose);
    menuBirds->addAction(actTurkey);
    menuBirds->addAction(actOwl);
    menuBirds->addAction(actEagle);
    menuBirds->addAction(actPenguin);
    menuBirds->addAction(actCrow);


    ui->menuBar->addMenu(menuDomesticAnimals);
    ui->menuBar->addMenu(menuWildAnimals);
    ui->menuBar->addMenu(menuBirds);


    ui->mainToolBar->addAction(actDog);
    ui->mainToolBar->addSeparator();
    ui->mainToolBar->addAction(actCat);
    ui->mainToolBar->addAction(actCow);
    ui->mainToolBar->addAction(actSheep);
    ui->mainToolBar->addAction(actRabbit);
    ui->mainToolBar->addAction(actHorse);
    ui->mainToolBar->addAction(actCow);
    ui->mainToolBar->addAction(actGoat);
    ui->mainToolBar->addAction(actChicken);
    ui->mainToolBar->addAction(actDonkey);
    ui->mainToolBar->addAction(actDuck);
    ui->mainToolBar->addAction(actGoose);
    ui->mainToolBar->addAction(actTurkey);
    ui->mainToolBar->addAction(actFish);
    ui->mainToolBar->addAction(actTurtle);
    ui->mainToolBar->addAction(actAlligator);
    ui->mainToolBar->addAction(actTiger);
    ui->mainToolBar->addAction(actRabbit);
    ui->mainToolBar->addAction(actLeo);
    ui->mainToolBar->addAction(actHorse);
    ui->mainToolBar->addAction(actGoat);
    ui->mainToolBar->addAction(actDuck);
    ui->mainToolBar->addAction(actGoose);
    ui->mainToolBar->addAction(actTurkey);
    ui->mainToolBar->addAction(actFox);
    ui->mainToolBar->addAction(actBear);
    ui->mainToolBar->addAction(actSnake);
    ui->mainToolBar->addAction(actMoose);
    ui->mainToolBar->addAction(actWolf);
    ui->mainToolBar->addAction(actOwl);
    ui->mainToolBar->addAction(actEagle);
    ui->mainToolBar->addAction(actRat);
    ui->mainToolBar->addAction(actPenguin);
    ui->mainToolBar->addAction(actCrow);
    this->setWindowTitle("Animals");

    connect(actDog, SIGNAL(triggered()),
            this,    SLOT(OnActDogTriggered()));
    connect(actCat, SIGNAL(triggered()),
            this,    SLOT(OnActTriggered()));
    connect(actCow, SIGNAL(triggered()),
            this,    SLOT(OnActTriggered()));
    connect(actSheep, SIGNAL(triggered()),
            this,    SLOT(OnActTriggered()));
    connect(actRabbit, SIGNAL(triggered()),
            this,    SLOT(OnActTriggered()));
    connect(actCow, SIGNAL(triggered()),
            this,    SLOT(OnActTriggered()));
    connect(actHorse, SIGNAL(triggered()),
            this,    SLOT(OnActTriggered()));
    connect(actGoat, SIGNAL(triggered()),
            this,    SLOT(OnActTriggered()));
    connect(actChicken, SIGNAL(triggered()),
            this,    SLOT(OnActTriggered()));
    connect(actDonkey, SIGNAL(triggered()),
            this,    SLOT(OnActTriggered()));
    connect(actDuck, SIGNAL(triggered()),
            this,    SLOT(OnActTriggered()));
    connect(actGoose, SIGNAL(triggered()),
            this,    SLOT(OnActTriggered()));
    connect(actTurkey, SIGNAL(triggered()),
            this,    SLOT(OnActTriggered()));
    connect(actFish, SIGNAL(triggered()),
            this,    SLOT(OnActTriggered()));
    connect(actTurtle, SIGNAL(triggered()),
            this,    SLOT(OnActTriggered()));
    connect(actAlligator, SIGNAL(triggered()),
            this,    SLOT(OnActTriggered()));
    connect(actTiger, SIGNAL(triggered()),
            this,    SLOT(OnActTriggered()));
    connect(actLeo, SIGNAL(triggered()),
            this,    SLOT(OnActTriggered()));
    connect(actFox, SIGNAL(triggered()),
            this,    SLOT(OnActTriggered()));
    connect(actBear, SIGNAL(triggered()),
            this,    SLOT(OnActTriggered()));
    connect(actSnake, SIGNAL(triggered()),
            this,    SLOT(OnActTriggered()));
    connect(actMoose, SIGNAL(triggered()),
            this,    SLOT(OnActTriggered()));
    connect(actWolf, SIGNAL(triggered()),
            this,    SLOT(OnActTriggered()));
    connect(actOwl, SIGNAL(triggered()),
            this,    SLOT(OnActTriggered()));
    connect(actEagle, SIGNAL(triggered()),
            this,    SLOT(OnActTriggered()));
    connect(actRat, SIGNAL(triggered()),
            this,    SLOT(OnActTriggered()));
    connect(actPenguin, SIGNAL(triggered()),
            this,    SLOT(OnActTriggered()));
    connect(actCrow, SIGNAL(triggered()),
            this,    SLOT(OnActTriggered()));
}

MainWindow::~MainWindow()
{
    delete ui;
}

void MainWindow::OnActTriggered()
{
    QMessageBox::warning(this, "WARNING!", "PROTECT THE ANIMALS!");
}

void MainWindow::OnActDogTriggered()
{
    QString link = "https://www.worldanimalprotection.org/";
    QDesktopServices::openUrl(link);
}
