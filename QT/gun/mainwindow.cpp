#include "mainwindow.h"
#include "ui_mainwindow.h"

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    ui->setupUi(this);
    scene = new QGraphicsScene(this);
    //graphicsView = new QGraphicsView();
    //ui->graphicsView->setScene(scene);


    //QGraphicsView view(*&scene);
    ourGun = new gun();
    scene->addItem(ourGun);
    //QGraphicsRectItem *something = new QGraphicsRectItem(ourGun ourGun);
    //scene->addItem(something);

    ui->graphicsView->setScene(scene);

    //view.show();
}

MainWindow::~MainWindow()
{
    delete ui;
}
