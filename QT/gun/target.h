#pragma once

#include <QGraphicsScene>
#include <QGraphicsView>
#include <QGraphicsItem>

class Target : public QGraphicsItem
{
public:
	Target(qreal x, qreal y);

	/// Rectangle for paint shell.
	QRectF boundingRect() const;

	/// Paint shell.
	void paint(QPainter *painter, const QStyleOptionGraphicsItem *option, QWidget *widget);

	/// Get value from position from x.
	qreal posX();

	/// Get value from position from x.
	qreal posY();

	/// Processing win.
	void winChanges();

	/// Start new game.
	void newGame();

	/// Chek win.
	bool isCheckWin();

private:
	qreal mShift;
	qreal mTurn;
	bool mWin = false;
};
