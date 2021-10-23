#include "mainwindow.h"
#include "ui_mainwindow.h"
#include <QFileDialog>
#include <QDesktopWidget>
#include <QPixmap>
#include <QPalette>
#include <QAction>
#include <QToolBar>
#include <QDesktopServices>
#include <QUrl>
#include <QPixmap>
#include <QScreen>
#include <QMessageBox>
#include <QPalette>
#include <QRandomGenerator>

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow),
    menuSuperHeroes(new QMenu(this)),
    menuSuperVillans(new QMenu(this)),
    actBatman(new QAction(this)),
    actCaptainAmerica(new QAction(this)),
    actCatwoman(new QAction(this)),
    actDoctordoom(new QAction(this)),
    actGalactus(new QAction(this)),
    actGreenlantern(new QAction(this)),
    actHarleyqueen(new QAction(this)),
    actHawkeye(new QAction(this)),
    actHulk(new QAction(this)),
    actIronman(new QAction(this)),
    actJoker(new QAction(this)),
    actLexluthor(new QAction(this)),
    actMagneto(new QAction(this)),
    actRedskull(new QAction(this)),
    actRobin(new QAction(this)),
    actSuperman(new QAction(this)),
    actThor(new QAction(this)),
    actReset(new QAction(this)),
    actSpiderman(new QAction(this)),
    actMoreInfo(new QAction(this)),
    actTheFlash(new QAction(this))
{
    ui->setupUi(this);

    this->move(QApplication::desktop()->screen()->rect().center() - this->rect().center());
    QPixmap pix1(":/images/Images/ImagesForSuperHeroesProject/SuperheroBackground.jpg");
    QPixmap pix2(":/images/Images/ImagesForSuperHeroesProject/SuperheroBackground.jpg");
    ui->HeroPictureLabel->setPixmap(pix1.scaled(400, 400));
    ui->VillanPictureLabel->setPixmap(pix2.scaled(400, 400));

    QPixmap bkgnd(":/images/Images/ImagesForSuperHeroesProject/background.jpg");
    bkgnd = bkgnd.scaled(this->size(), Qt::IgnoreAspectRatio);
    QPalette palette;
    palette.setBrush(QPalette::Background, bkgnd);
    this->setPalette(palette);

    menuSuperHeroes->setTitle(tr("&SuperHeroes"));
    menuSuperVillans->setTitle(tr("&SuperVillans"));

    actBatman->setText("&Batman");
    actBatman->setIcon(QIcon(":/images/Images/ImagesForSuperHeroesProject/BatmanIcon.png"));
    actCaptainAmerica->setText("&CaptainAmerica");
    actCaptainAmerica->setIcon(QIcon(":/images/Images/ImagesForSuperHeroesProject/CaptainAmericaIcon.png"));
    actCatwoman->setText("&Catwoman");
    actCatwoman->setIcon(QIcon(":/images/Images/ImagesForSuperHeroesProject/CatwomanIcon.png"));
    actDoctordoom->setText("&DoctorDoom");
    actDoctordoom->setIcon(QIcon(":/images/Images/ImagesForSuperHeroesProject/DoctorDoom.png"));
    actGalactus->setText("&Galactus");
    actGalactus->setIcon(QIcon(":/images/Images/ImagesForSuperHeroesProject/GalactusIcon.jpg"));
    actGreenlantern->setText("&GreenLantern");
    actGreenlantern->setIcon(QIcon(":/images/Images/ImagesForSuperHeroesProject/GreenlanternIcon.png"));
    actHarleyqueen->setText("&HarleyQueen");
    actHarleyqueen->setIcon(QIcon(":/images/Images/ImagesForSuperHeroesProject/HarleyQueenIcon.jpg"));
    actHawkeye->setText("&Hawkeye");
    actHawkeye->setIcon(QIcon(":/images/Images/ImagesForSuperHeroesProject/HawkeyeIcon.png"));
    actHulk->setText("&Hulk");
    actHulk->setIcon(QIcon(":/images/Images/ImagesForSuperHeroesProject/HulkIcon.png"));
    actIronman->setText("&Ironman");
    actIronman->setIcon(QIcon(":/images/Images/ImagesForSuperHeroesProject/IronmanIcon.png"));
    actJoker->setText("&Joker");
    actJoker->setIcon(QIcon(":/images/Images/ImagesForSuperHeroesProject/JokerIcon.png"));
    actLexluthor->setText("&LexLuhtor");
    actLexluthor->setIcon(QIcon(":/images/Images/ImagesForSuperHeroesProject/LexLuthorIcon.png"));
    actMagneto->setText("&Magneto");
    actMagneto->setIcon(QIcon(":/images/Images/ImagesForSuperHeroesProject/MagnetoIcon.jpg"));
    actRedskull->setText("&Redskull");
    actRedskull->setIcon(QIcon(":/images/Images/ImagesForSuperHeroesProject/RedskullIcon.png"));
    actRobin->setText("&Robin");
    actRobin->setIcon(QIcon(":/images/Images/ImagesForSuperHeroesProject/RobinIcon.png"));
    actSuperman->setText("&Superman");
    actSuperman->setIcon(QIcon(":/images/Images/ImagesForSuperHeroesProject/SupermanIcon.png"));
    actThor->setText("&Thor");
    actThor->setIcon(QIcon(":/images/Images/ImagesForSuperHeroesProject/ThorIcon.jpg"));
    actSpiderman->setText("&Spiderman");
    actSpiderman->setIcon(QIcon(":/images/Images/ImagesForSuperHeroesProject/SpidermanIcon.png"));
    actTheFlash->setText("&TheFlash");
    actTheFlash->setIcon(QIcon(":/images/Images/ImagesForSuperHeroesProject/TheFlash.png"));

    actReset->setText("&Reset");
    actReset->setIcon(QIcon(":/images/Images/ImagesForSuperHeroesProject/ResetIcon.png"));

    actMoreInfo->setText("&MoreInfo");
    actMoreInfo->setIcon(QIcon(":/images/Images/ImagesForSuperHeroesProject/MoreInfo.png"));

    menuSuperHeroes->addAction(actBatman);
    menuSuperHeroes->addAction(actCaptainAmerica);
    menuSuperVillans->addAction(actCatwoman);
    menuSuperHeroes->addAction(actGreenlantern);
    menuSuperHeroes->addAction(actHawkeye);
    menuSuperHeroes->addAction(actHulk);
    menuSuperHeroes->addAction(actIronman);
    menuSuperHeroes->addAction(actRobin);
    menuSuperHeroes->addAction(actSuperman);
    menuSuperHeroes->addAction(actThor);
    menuSuperHeroes->addAction(actSpiderman);
    menuSuperHeroes->addAction(actTheFlash);

    menuSuperVillans->addAction(actJoker);
    menuSuperVillans->addAction(actDoctordoom);
    menuSuperVillans->addAction(actGalactus);
    menuSuperVillans->addAction(actHarleyqueen);
    menuSuperVillans->addAction(actLexluthor);
    menuSuperVillans->addAction(actMagneto);
    menuSuperVillans->addAction(actRedskull);

    ui->menuBar->addMenu(menuSuperHeroes);
    ui->menuBar->addMenu(menuSuperVillans);


    ui->mainToolBar->addAction(actReset); //////// asta schimba la loc imaginile
    ui->mainToolBar->addSeparator();
    ui->mainToolBar->addAction(actMoreInfo);

    this->setWindowTitle("SuperFight");

    connect(actBatman, SIGNAL(triggered()),
            this,    SLOT(OnActBatmanTriggered()));
    connect(actCaptainAmerica, SIGNAL(triggered()),
            this,    SLOT(OnActCaptainamericaTriggered()));
    connect(actCatwoman, SIGNAL(triggered()),
            this,    SLOT(OnActCatwomanTriggered()));
    connect(actDoctordoom, SIGNAL(triggered()),
            this,    SLOT(OnActDoctordoomTriggered()));
    connect(actGalactus, SIGNAL(triggered()),
            this,    SLOT(OnActGalactusTriggered()));
    connect(actGreenlantern, SIGNAL(triggered()),
            this,    SLOT(OnActGreenlanternTriggered()));
    connect(actHarleyqueen, SIGNAL(triggered()),
            this,    SLOT(OnActHarleyqueenTriggered()));
    connect(actHawkeye, SIGNAL(triggered()),
            this,    SLOT(OnActHawkeyeTriggered()));
    connect(actHulk, SIGNAL(triggered()),
            this,    SLOT(OnActHulkTriggered()));
    connect(actIronman, SIGNAL(triggered()),
            this,    SLOT(OnActIronmanTriggered()));
    connect(actLexluthor, SIGNAL(triggered()),
            this,    SLOT(OnActLexluthorTriggered()));
    connect(actRedskull, SIGNAL(triggered()),
            this,    SLOT(OnActRedskullTriggered()));
    connect(actRobin, SIGNAL(triggered()),
            this,    SLOT(OnActRobinTriggered()));
    connect(actSpiderman, SIGNAL(triggered()),
            this,    SLOT(OnActSpidermanTriggered()));
    connect(actSuperman, SIGNAL(triggered()),
            this,    SLOT(OnActSupermanTriggered()));
    connect(actThor, SIGNAL(triggered()),
            this,    SLOT(OnActThorTriggered()));
    connect(actMagneto, SIGNAL(triggered()),
            this, SLOT(OnActMagnetoTriggered()));
    connect(actJoker, SIGNAL(triggered()),
            this, SLOT(OnActJokerTriggered()));
    connect(actReset, SIGNAL(triggered()),
            this, SLOT(OnActResetTriggered()));
    connect(actMoreInfo, SIGNAL(triggered()),
            this, SLOT(OnActMoreInfoTriggered()));
    connect(actTheFlash, SIGNAL(triggered()),
            this, SLOT(OnActTheFlashTriggered()));
}

MainWindow::~MainWindow()
{
    delete ui;
}

void MainWindow::OnActBatmanTriggered() /////////////!!!!!!!!!!!!!!!
{
    QPixmap pix(":/images/Images/ImagesForSuperHeroesProject/Batman.jpg");
    ui->HeroPictureLabel->setPixmap(pix.scaled(400, 400));
    setFocus();
}

void MainWindow::OnActCaptainamericaTriggered()
{
    QPixmap pix(":/images/Images/ImagesForSuperHeroesProject/CaptainAmerica.jpg");
    ui->HeroPictureLabel->setPixmap(pix.scaled(400, 400));
    setFocus();
}

void MainWindow::OnActCatwomanTriggered()
{
    QPixmap pix(":/images/Images/ImagesForSuperHeroesProject/Catwoman.jpg");
    ui->VillanPictureLabel->setPixmap(pix.scaled(400, 400));
    setFocus();
}

void MainWindow::OnActDoctordoomTriggered()
{
    QPixmap pix(":/images/Images/ImagesForSuperHeroesProject/DoctorDoom.jpg");
    ui->VillanPictureLabel->setPixmap(pix.scaled(400, 400));
    setFocus();
}

void MainWindow::OnActGalactusTriggered()
{
    QPixmap pix(":/images/Images/ImagesForSuperHeroesProject/Galactus.jpg");
    ui->VillanPictureLabel->setPixmap(pix.scaled(400, 400));
    setFocus();
}

void MainWindow::OnActGreenlanternTriggered()
{
    QPixmap pix(":/images/Images/ImagesForSuperHeroesProject/Greenlantern.jpg");
    ui->HeroPictureLabel->setPixmap(pix.scaled(400, 400));
    setFocus();
}

void MainWindow::OnActHarleyqueenTriggered()
{
    QPixmap pix(":/images/Images/ImagesForSuperHeroesProject/HarleyQueen.jpg");
    ui->VillanPictureLabel->setPixmap(pix.scaled(400, 400));
    setFocus();
}

void MainWindow::OnActHawkeyeTriggered()
{
    QPixmap pix(":/images/Images/ImagesForSuperHeroesProject/Hawkeye.jpg");
    ui->HeroPictureLabel->setPixmap(pix.scaled(400, 400));
    setFocus();
}

void MainWindow::OnActHulkTriggered()
{
    QPixmap pix(":/images/Images/ImagesForSuperHeroesProject/Hulk.jpg");
    ui->HeroPictureLabel->setPixmap(pix.scaled(400, 400));
    setFocus();
}

void MainWindow::OnActIronmanTriggered()
{
    QPixmap pix(":/images/Images/ImagesForSuperHeroesProject/Ironman.jpg");
    ui->HeroPictureLabel->setPixmap(pix.scaled(400, 400));
    setFocus();
}

void MainWindow::OnActJokerTriggered()
{
    QPixmap pix(":/images/Images/ImagesForSuperHeroesProject/Joker.jpg");
    ui->VillanPictureLabel->setPixmap(pix.scaled(400, 400));
    setFocus();
}

void MainWindow::OnActLexluthorTriggered()
{
    QPixmap pix(":/images/Images/ImagesForSuperHeroesProject/LexLuthor.jpg");
    ui->VillanPictureLabel->setPixmap(pix.scaled(400, 400));
    setFocus();
}

void MainWindow::OnActMagnetoTriggered()
{
    QPixmap pix(":/images/Images/ImagesForSuperHeroesProject/Magneto.jpg");
    ui->VillanPictureLabel->setPixmap(pix.scaled(400, 400));
    setFocus();
}

void MainWindow::OnActRedskullTriggered()
{
    QPixmap pix(":/images/Images/ImagesForSuperHeroesProject/RedSkull.jpg");
    ui->VillanPictureLabel->setPixmap(pix.scaled(400, 400));
    setFocus();
}

void MainWindow::OnActRobinTriggered()
{
    QPixmap pix(":/images/Images/ImagesForSuperHeroesProject/Robin.jpg");
    ui->HeroPictureLabel->setPixmap(pix.scaled(400, 400));
    setFocus();
}

void MainWindow::OnActSpidermanTriggered()
{
    QPixmap pix(":/images/Images/ImagesForSuperHeroesProject/Spiderman.jpg");
    ui->HeroPictureLabel->setPixmap(pix.scaled(400, 400));
    setFocus();
}

void MainWindow::OnActSupermanTriggered()
{
    QPixmap pix(":/images/Images/ImagesForSuperHeroesProject/Superman.jpg");
    ui->HeroPictureLabel->setPixmap(pix.scaled(400, 400));
    setFocus();
}

void MainWindow::OnActThorTriggered()
{
    QPixmap pix(":/images/Images/ImagesForSuperHeroesProject/Thor.jpg");
    ui->HeroPictureLabel->setPixmap(pix.scaled(400, 400));
    setFocus();
}

void MainWindow::OnActTheFlashTriggered()
{
    QPixmap pix(":/images/Images/ImagesForSuperHeroesProject/TheFlashAvatar.jpg");
    ui->HeroPictureLabel->setPixmap(pix.scaled(400, 400));
    setFocus();
}

void MainWindow::OnActResetTriggered()
{
    QPixmap pix(":/images/Images/ImagesForSuperHeroesProject/SuperheroBackground.jpg");
    ui->HeroPictureLabel->setPixmap(pix.scaled(400, 400));
    ui->VillanPictureLabel->setPixmap(pix.scaled(400,400));
    setFocus();
}

void MainWindow::OnActMoreInfoTriggered()
{
    QString link = "https://www.marvel.com/characters";
    QDesktopServices::openUrl(link);
}



void MainWindow::on_pushButton_clicked()
{
    QPixmap Victorious(":/images/Images/ImagesForSuperHeroesProject/Victory.jpg");
    QPixmap Defeated(":/images/Images/ImagesForSuperHeroesProject/Defeated.jpg");

    if (rand() % 2 == 0)
    {
        ui->HeroPictureLabel->setPixmap(Victorious.scaled(400, 400));
        ui->VillanPictureLabel->setPixmap(Defeated.scaled(400, 400));
    }
    else
    {
        ui->VillanPictureLabel->setPixmap(Victorious.scaled(400, 400));
        ui->HeroPictureLabel->setPixmap(Defeated.scaled(400, 400));
    }
}

