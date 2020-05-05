<?php
// automatically generated by the FlatBuffers compiler, do not modify

namespace ppx;

use \Google\FlatBuffers\Struct;
use \Google\FlatBuffers\Table;
use \Google\FlatBuffers\ByteBuffer;
use \Google\FlatBuffers\FlatBufferBuilder;

class Gamma extends Table
{
    /**
     * @param ByteBuffer $bb
     * @return Gamma
     */
    public static function getRootAsGamma(ByteBuffer $bb)
    {
        $obj = new Gamma();
        return ($obj->init($bb->getInt($bb->getPosition()) + $bb->getPosition(), $bb));
    }

    public static function GammaIdentifier()
    {
        return "PPXF";
    }

    public static function GammaBufferHasIdentifier(ByteBuffer $buf)
    {
        return self::__has_identifier($buf, self::GammaIdentifier());
    }

    /**
     * @param int $_i offset
     * @param ByteBuffer $_bb
     * @return Gamma
     **/
    public function init($_i, ByteBuffer $_bb)
    {
        $this->bb_pos = $_i;
        $this->bb = $_bb;
        return $this;
    }

    public function getConcentration()
    {
        $obj = new Tensor();
        $o = $this->__offset(4);
        return $o != 0 ? $obj->init($this->__indirect($o + $this->bb_pos), $this->bb) : 0;
    }

    public function getRate()
    {
        $obj = new Tensor();
        $o = $this->__offset(6);
        return $o != 0 ? $obj->init($this->__indirect($o + $this->bb_pos), $this->bb) : 0;
    }

    /**
     * @param FlatBufferBuilder $builder
     * @return void
     */
    public static function startGamma(FlatBufferBuilder $builder)
    {
        $builder->StartObject(2);
    }

    /**
     * @param FlatBufferBuilder $builder
     * @return Gamma
     */
    public static function createGamma(FlatBufferBuilder $builder, $concentration, $rate)
    {
        $builder->startObject(2);
        self::addConcentration($builder, $concentration);
        self::addRate($builder, $rate);
        $o = $builder->endObject();
        return $o;
    }

    /**
     * @param FlatBufferBuilder $builder
     * @param int
     * @return void
     */
    public static function addConcentration(FlatBufferBuilder $builder, $concentration)
    {
        $builder->addOffsetX(0, $concentration, 0);
    }

    /**
     * @param FlatBufferBuilder $builder
     * @param int
     * @return void
     */
    public static function addRate(FlatBufferBuilder $builder, $rate)
    {
        $builder->addOffsetX(1, $rate, 0);
    }

    /**
     * @param FlatBufferBuilder $builder
     * @return int table offset
     */
    public static function endGamma(FlatBufferBuilder $builder)
    {
        $o = $builder->endObject();
        return $o;
    }
}