#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>
#include <QMenu>
#include <QAction>

namespace Ui {
class MainWindow;
}

class MainWindow : public QMainWindow
{
    Q_OBJECT

public:
    explicit MainWindow(QWidget *parent = nullptr);
    ~MainWindow();

private slots:
    void OnActTriggered();
    void OnActDogTriggered();

private:
    Ui::MainWindow *ui;

    QMenu *menuDomesticAnimals;
    QMenu *menuWildAnimals;
    QMenu *menuBirds;

    QAction *actDog;
    QAction *actCat;
    QAction *actFish;
    QAction *actTurtle;
    QAction *actLeo;
    QAction *actAlligator;
    QAction *actHorse;
    QAction *actCow;
    QAction *actPig;
    QAction *actTiger;
    QAction *actSheep;
    QAction *actRabbit;
    QAction *actGoat;
    QAction *actChicken;
    QAction *actDonkey;
    QAction *actDuck;
    QAction *actGoose;
    QAction *actTurkey;
    QAction *actFox;
    QAction *actBear;
    QAction *actSnake;
    QAction *actMoose;
    QAction *actWolf;
    QAction *actOwl;
    QAction *actEagle;
    QAction *actRat;
    QAction *actPenguin;
    QAction *actCrow;
};

#endif // MAINWINDOW_H
