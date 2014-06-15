#pragma once
#include <QGraphicsScene>
#include <QGraphicsView>
class gun
{
public:
    gun();
    void draw();

private:
    QGraphicsScene *scene = new QGraphicsScene();
}
;
