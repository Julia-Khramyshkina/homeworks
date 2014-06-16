#include "target.h"

target::target(QGraphicsScene *somethingScene)
{
    scene = somethingScene;
}

void target::draw()
{
    scene->addEllipse(400, 10, 30, 30);
}
