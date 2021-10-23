#ifndef PICTURELABEL2_H
#define PICTURELABEL2_H

#include <QObject>
#include <QLabel>

class PictureLabel2 : public QLabel
{
    Q_OBJECT
public:
    PictureLabel2(QWidget* parent = nullptr);
protected:
    void enterEvent(QEvent* event) override;
    void leaveEvent(QEvent* event) override;
    void mousePressEvent(QMouseEvent* event) override;
};

#endif // PICTURELABEL2_H
