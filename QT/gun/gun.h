#pragma once
#include <QGraphicsScene>
#include <QGraphicsView>
class gun
{
public:
    gun(QGraphicsScene *somethingScene);

    void draw();

private:
    QGraphicsScene *scene;
}
;
