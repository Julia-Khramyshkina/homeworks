#pragma once

#include <QMainWindow>

#include <QGraphicsScene>

#include <QGraphicsView>

#include <QtCore>

#include <QtGui>

#include <QDialog>

#include <QWidget>

#include "target.h"

namespace Ui {
class MainWindow;
}

/// Class for gun.
class Gun;

/// Class for shell.
class Shell;

class MainWindow : public QMainWindow
{
    Q_OBJECT

public:
    explicit MainWindow(QWidget *parent = 0);

    /// Processing and verification of cases to win.
    void win();
    ~MainWindow();

public slots:

    /// Movement down the barrel.
    void down();

    /// Movement up the barrel.
    void up();

    /// Shot.
    void fire();

    /// Timer update.
    void timerUpdate();

    /// Rate selection. Slowly.
    void slowly();

    /// Rate selection. Medium.
    void medium();

    /// Rate selection. Quickly.
    void quickly();

private:
    Ui::MainWindow *ui;
    QGraphicsScene *scene;
    Gun *ourGun;
    Target *ourTarget;
    Shell *ourShell;
    QTimer *timer;
    bool changeSpeed = false;
    qreal speed;
    qreal interval = 100;
};
