#include "mainwindow.h"
#include <QApplication>
#include <QGraphicsScene>
#include <QGraphicsView>
#include "gun.h"
#include "target.h"

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);
    MainWindow w;
    w.show();
    //QGraphicsScene *scene = new QGraphicsScene();
    //scene->
    /*scene->activeWindow();
    gun *thisGun = new gun(scene);
    thisGun->draw();
    target *thisTarget = new target(scene);
    thisTarget->draw();
*/



    //view.setAlignment(Qt::AlignLeft | Qt::AlignTop);

    //view.show();

    return a.exec();
}

