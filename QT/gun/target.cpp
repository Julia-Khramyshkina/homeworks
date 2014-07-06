#include "target.h"

Target::Target(qreal x, qreal y)
{
	this->mShift = x;
	this->mTurn = y;
}

QRectF Target::boundingRect() const
{
	 return QRectF(225, -30, 50, 50);
}

void Target:: paint(QPainter *painter, const QStyleOptionGraphicsItem *option, QWidget *widget)
{
	painter->drawEllipse(220, 20, 30, 30);
	if (mWin)
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
	this->mWin = true;
}

void Target::newGame()
{
	this->mWin = false;
}

bool Target::isCheckWin()
{
	return this->mWin;
}
