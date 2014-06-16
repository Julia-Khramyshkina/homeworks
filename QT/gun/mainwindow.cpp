#include "mainwindow.h"
#include "ui_mainwindow.h"

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    ui->setupUi(this);
    scene = new QGraphicsScene(this);

    ellipse = scene->addEllipse(10, 200, 100, 70);
    rect = scene->addRect(110, 230, 40, 10);
}

MainWindow::~MainWindow()
{
    delete ui;
}
