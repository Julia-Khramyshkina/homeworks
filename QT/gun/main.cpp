#include "mainwindow.h"
#include <QApplication>
#include <QGraphicsScene>
#include <QGraphicsView>
#include "gun.h"

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);
/*    MainWindow w;
    w.show();*/
    QGraphicsScene *scene;
    gun *thisGun = new gun();
    thisGun->draw();



    QGraphicsView view(*&scene);
    view.show();

    return a.exec();
}

