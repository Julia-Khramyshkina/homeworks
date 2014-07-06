#include "target.h"

Target::Target(qreal x, qreal y)
{
	this->shift = x;
	this->turn = y;
}

QRectF Target::boundingRect() const
{
	 return QRectF(225, -30, 50, 50);
}

void Target:: paint(QPainter *painter, const QStyleOptionGraphicsItem *option, QWidget *widget)
{
	painter->drawEllipse(220, 20, 30, 30);
	if (win)
	{
		painter->setBrush(Qt::blue);
		painter->drawEllipse(220, 20, 30, 30);
	}
}

qreal Target::posX()
{
	return 220;
}

qreal Target::posY()
{
	return 20;
}

void Target::winChanges()
{
	this->win = true;
}

void Target::newGame()
{
	this->win = false;
}

bool Target::isCheckWin()
{
	return this->win;
}
