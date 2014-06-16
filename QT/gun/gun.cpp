#include "gun.h"
#include <QTransform>

gun::gun(QGraphicsScene *somethingScene)
{
    scene = somethingScene;
}

void gun:: draw()
{
    scene->addEllipse(10, 200, 100, 70);
    scene->addRect(110, 230, 40, 10);
}

