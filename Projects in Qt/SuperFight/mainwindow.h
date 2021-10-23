#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>
#include <QMenu>
#include <QAction>
#include <QScreen>
#include <QStyleFactory>

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
    void OnActBatmanTriggered();
    void OnActCaptainamericaTriggered();
    void OnActCatwomanTriggered();
    void OnActDoctordoomTriggered();
    void OnActGalactusTriggered();
    void OnActGreenlanternTriggered();
    void OnActHarleyqueenTriggered();
    void OnActHawkeyeTriggered();
    void OnActHulkTriggered();
    void OnActIronmanTriggered();
    void OnActJokerTriggered();
    void OnActLexluthorTriggered();
    void OnActMagnetoTriggered();
    void OnActRedskullTriggered();
    void OnActRobinTriggered();
    void OnActSpidermanTriggered();
    void OnActSupermanTriggered();
    void OnActThorTriggered();
    void OnActTheFlashTriggered();
    void OnActResetTriggered();
    void OnActMoreInfoTriggered();

    void on_pushButton_clicked();

private:
    Ui::MainWindow *ui;

    QMenu *menuSuperHeroes;
    QMenu *menuSuperVillans;

    QAction *actBatman;
    QAction *actCaptainAmerica;
    QAction *actCatwoman;
    QAction *actDoctordoom;
    QAction *actGalactus;
    QAction *actGreenlantern;
    QAction *actHarleyqueen;
    QAction *actHawkeye;
    QAction *actHulk;
    QAction *actIronman;
    QAction *actJoker;
    QAction *actLexluthor;
    QAction *actMagneto;
    QAction *actRedskull;
    QAction *actRobin;
    QAction *actSuperman;
    QAction *actThor;
    QAction *actReset;
    QAction *actSpiderman;
    QAction *actMoreInfo;
    QAction *actTheFlash;
};

#endif // MAINWINDOW_H
